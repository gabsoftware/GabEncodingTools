using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace GabSoftware.Utils
{
    public static class EncodingTools
    {
        public static string test = string.Empty;
        
        // this only contains ascii, default windows code page and unicode
        public static int[] PreferedEncodingsForStream;

        // this contains all codepages, sorted by preference and byte usage 
        public static int[] PreferedEncodings;

        // this contains all codepages, sorted by preference and byte usage 
        public static int[] AllEncodings;

        // this is the first code page we will search for.
        public static int MyPreferedEncodingCodePage;

        
        
        /// <summary>
        /// Static constructor that fills the default preferred codepages
        /// </summary>
        static EncodingTools()
        {

            List<int> streamEncodings= new List<int>();
            List<int> allEncodings = new List<int>();
            List<int> mimeEncodings = new List<int>();

            // asscii - most simple so put it in first place...
            streamEncodings.Add(Encoding.ASCII.CodePage);
            mimeEncodings.Add(Encoding.ASCII.CodePage);
            allEncodings.Add(Encoding.ASCII.CodePage);
     
            // add default 2nd for all encodings
            allEncodings.Add(Encoding.Default.CodePage);
            // default is single byte?
            if (Encoding.Default.IsSingleByte)
            {
                // put it in second place
                streamEncodings.Add(Encoding.Default.CodePage);
                mimeEncodings.Add(Encoding.Default.CodePage);
            }

            // prefer JIS over JIS-SHIFT (JIS is detected better than JIS-SHIFT)
            // this one does include cyrilic (strange but true)
            allEncodings.Add(50220);
            mimeEncodings.Add(50220);


            // always allow unicode flavours for streams (they all have a preamble)
            streamEncodings.Add(Encoding.Unicode.CodePage);
            foreach (EncodingInfo enc in Encoding.GetEncodings())
            {
                if (!streamEncodings.Contains(enc.CodePage))
                {
                    Encoding encoding = Encoding.GetEncoding(enc.CodePage);
                    if (encoding.GetPreamble().Length > 0)
                        streamEncodings.Add(enc.CodePage);
                }
            }

            // stream is done here
            PreferedEncodingsForStream = streamEncodings.ToArray();

            // all singlebyte encodings
            foreach (EncodingInfo enc in Encoding.GetEncodings())
            {
                

                if (!enc.GetEncoding().IsSingleByte)
                    continue;

                if (!allEncodings.Contains(enc.CodePage))
                    allEncodings.Add(enc.CodePage);

                // only add iso and IBM encodings to mime encodings 
                if (enc.CodePage <= 1258)
                {
                    mimeEncodings.Add(enc.CodePage);
                }
            }

            // add the rest (multibyte)
            foreach (EncodingInfo enc in Encoding.GetEncodings())
            {
                if (!enc.GetEncoding().IsSingleByte)
                {
                    if (!allEncodings.Contains(enc.CodePage))
                        allEncodings.Add(enc.CodePage);

                    // only add iso and IBM encodings to mime encodings 
                    if (enc.CodePage <= 1258)
                    {
                        mimeEncodings.Add(enc.CodePage);
                    }
                }
            }

            // add unicodes
            mimeEncodings.Add(Encoding.Unicode.CodePage);

            PreferedEncodings = mimeEncodings.ToArray();
            AllEncodings = allEncodings.ToArray();

            int i;
            for (i = 0; i <= PreferedEncodings.Length-1; i++)
            {
                test += Encoding.GetEncoding(PreferedEncodings[i]).EncodingName + Environment.NewLine;
            }

        }


        /// <summary>
        /// Checks if specified string data is acii data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsAscii(string data)
        {
            // assume empty string to be ascii
            if ((data == null) || (data.Length == 0))
                return true;
            foreach (char c in data)
            {
                if ((int)c > 127)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets the best Encoding for usage in mime encodings
        /// </summary>
        /// <param name="input">text to detect</param>
        /// <returns>the suggested encoding</returns>
        public static Encoding GetMostEfficientEncoding(string input)
        {
            return GetMostEfficientEncoding(input, PreferedEncodings);
        }

        /// <summary>
        /// Gets the best ISO Encoding for usage in a stream
        /// </summary>
        /// <param name="input">text to detect</param>
        /// <returns>the suggested encoding</returns>
        public static Encoding GetMostEfficientEncodingForStream(string input)
        {
            return GetMostEfficientEncoding(input, PreferedEncodingsForStream);
        }

        /// <summary>
        /// Gets the best fitting encoding from a list of possible encodings
        /// </summary>
        /// <param name="input">text to detect</param>
        /// <param name="preferedEncodings">an array of codepages</param>
        /// <returns>the suggested encoding</returns>
        public static Encoding GetMostEfficientEncoding(string input, int[] preferedEncodings)
        {
            Encoding enc = DetectOutgoingEncoding(input,preferedEncodings,true);
            // unicode.. hmmm... check for smallest encoding
            if (enc.CodePage == Encoding.Unicode.CodePage)
            {
                int byteCount = Encoding.UTF7.GetByteCount(input);
                enc = Encoding.UTF7;
                int bestByteCount = byteCount;

                // utf8 smaller?
                byteCount = Encoding.UTF8.GetByteCount(input);
                if (byteCount < bestByteCount)
                {
                    enc = Encoding.UTF8;
                    bestByteCount = byteCount;
                }

                // unicode smaller?
                byteCount = Encoding.Unicode.GetByteCount(input);
                if (byteCount < bestByteCount)
                {
                    enc = Encoding.Unicode;
                    bestByteCount = byteCount;
                }
            }
            else
            {
                
            }
            return enc;
        }

        public static Encoding DetectOutgoingEncoding(string input)
        {
            return DetectOutgoingEncoding(input, PreferedEncodings, true);
        }

        public static Encoding DetectOutgoingStreamEncoding(string input)
        {
            return DetectOutgoingEncoding(input, PreferedEncodingsForStream, true);
        }

        public static Encoding[] DetectOutgoingEncodings(string input)
        {
            return DetectOutgoingEncodings(input, PreferedEncodings, true);
        }

        public static Encoding[] DetectOutgoingStreamEncodings(string input)
        {
            return DetectOutgoingEncodings(input, PreferedEncodingsForStream, true);
        }

        private static Encoding DetectOutgoingEncoding(string input, int[] preferedEncodings, bool preserveOrder)
        {

            if (input == null)
                throw new ArgumentNullException("input");

            // empty strings can always be encoded as ASCII
            if (input.Length == 0)
                return Encoding.ASCII;

            Encoding result = Encoding.ASCII;

            // get the IMultiLanguage3 interface
            MultiLanguage.IMultiLanguage3 multilang3 = new MultiLanguage.CMultiLanguageClass();
            if (multilang3 == null)
                throw new System.Runtime.InteropServices.COMException("Failed to get IMultilang3");
            try
            {
                int[] resultCodePages = new int[preferedEncodings != null ? preferedEncodings.Length : Encoding.GetEncodings().Length];
                uint detectedCodepages = (uint)resultCodePages.Length;
                ushort specialChar = (ushort)'?';


                // get unmanaged arrays
                IntPtr pPrefEncs = preferedEncodings == null ? IntPtr.Zero : Marshal.AllocCoTaskMem(sizeof(uint) * preferedEncodings.Length);
                IntPtr pDetectedEncs = Marshal.AllocCoTaskMem(sizeof(uint) * resultCodePages.Length);

                try
                {
                    if (preferedEncodings != null)
                        Marshal.Copy(preferedEncodings, 0, pPrefEncs, preferedEncodings.Length);

                    Marshal.Copy(resultCodePages, 0, pDetectedEncs, resultCodePages.Length);

                    MultiLanguage.MLCPF options = MultiLanguage.MLCPF.MLDETECTF_VALID_NLS;
                    if (preserveOrder)
                        options |= MultiLanguage.MLCPF.MLDETECTF_PRESERVE_ORDER;

                    if (preferedEncodings != null)
                        options |= MultiLanguage.MLCPF.MLDETECTF_PREFERRED_ONLY;

                    MultiLanguage.HRESULT hres;

                    hres = multilang3.DetectOutboundCodePage(
                        options,  
                        input,
                        (uint)input.Length,
                        pPrefEncs,
                        (uint) (preferedEncodings==null ? 0 : preferedEncodings.Length),
                        pDetectedEncs,
                        ref detectedCodepages, 
                        ref specialChar);

                    if (hres != MultiLanguage.HRESULT.S_OK)
                    {
                        MessageBox.Show("Error 1 ! HRESULT=" + hres.ToString());
                    }

                    // get result
                    if (detectedCodepages > 0)
                    {
                        int[] theResult = new int[detectedCodepages];
                        Marshal.Copy(pDetectedEncs, theResult, 0, theResult.Length);
                        result = Encoding.GetEncoding(theResult[0]);
                    }

                }
                finally
                {
                    if (pPrefEncs != IntPtr.Zero)
                        Marshal.FreeCoTaskMem(pPrefEncs);
                    Marshal.FreeCoTaskMem(pDetectedEncs);
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(multilang3);
            }
            return result;
        }

        public static Encoding[] DetectOutgoingEncodings(string input, int[] preferedEncodings, bool preserveOrder)
        {

            if (input == null)
                throw new ArgumentNullException("input");

            // empty strings can always be encoded as ASCII
            if (input.Length == 0)
                return new Encoding[] { Encoding.ASCII };

            List<Encoding> result = new List<Encoding>();

            // get the IMultiLanguage3 interface
            MultiLanguage.IMultiLanguage3 multilang3 = new MultiLanguage.CMultiLanguageClass();
            if (multilang3 == null)
                throw new System.Runtime.InteropServices.COMException("Failed to get IMultilang3");
            try
            {
                int[] resultCodePages = new int[preferedEncodings.Length];
                uint detectedCodepages = (uint)resultCodePages.Length;
                ushort specialChar = (ushort)'?';


                // get unmanaged arrays
                IntPtr pPrefEncs = Marshal.AllocCoTaskMem(sizeof(uint) * preferedEncodings.Length);
                IntPtr pDetectedEncs =  preferedEncodings == null ? IntPtr.Zero : Marshal.AllocCoTaskMem(sizeof(uint) * resultCodePages.Length);

                try
                {
                    if (preferedEncodings != null)
                        Marshal.Copy(preferedEncodings, 0, pPrefEncs, preferedEncodings.Length);

                    Marshal.Copy(resultCodePages, 0, pDetectedEncs, resultCodePages.Length);

                    MultiLanguage.MLCPF options = MultiLanguage.MLCPF.MLDETECTF_VALID_NLS | MultiLanguage.MLCPF.MLDETECTF_PREFERRED_ONLY;
                    if (preserveOrder)
                        options |= MultiLanguage.MLCPF.MLDETECTF_PRESERVE_ORDER;

                    if (preferedEncodings != null)
                        options |= MultiLanguage.MLCPF.MLDETECTF_PREFERRED_ONLY;

                    // finally... call to DetectOutboundCodePage
                    MultiLanguage.HRESULT hres;

                    hres = multilang3.DetectOutboundCodePage(
                        options,
                        input, 
                        (uint)input.Length,
                        pPrefEncs, 
                        (uint) (preferedEncodings==null ? 0 : preferedEncodings.Length),
                        pDetectedEncs, 
                        ref detectedCodepages,
                        ref specialChar);

                    if (hres != MultiLanguage.HRESULT.S_OK)
                    {
                        MessageBox.Show("Error 2 ! HRESULT=" + hres.ToString());
                    }

                    // get result
                    if (detectedCodepages > 0)
                    {
                        int[] theResult = new int[detectedCodepages];
                        Marshal.Copy(pDetectedEncs, theResult, 0, theResult.Length);


                        // get the encodings for the codepages
                        for (int i = 0; i < detectedCodepages; i++)
                            result.Add(Encoding.GetEncoding(theResult[i]));
                        
                    }

                }
                finally
                {
                    if (pPrefEncs != IntPtr.Zero)
                        Marshal.FreeCoTaskMem(pPrefEncs);
                    Marshal.FreeCoTaskMem(pDetectedEncs);
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(multilang3);
            }
            // nothing found
            return result.ToArray();
        }


        /// <summary>
        /// Detect the most probable codepage from an byte array
        /// </summary>
        /// <param name="input">array containing the raw data</param>
        /// <returns>the detected encoding or the default encoding if the detection failed</returns>
        public static Encoding DetectInputCodepage(byte[] input)
        {
            try
            {
                Encoding[] detected = DetectInputCodepages(input, 1, (uint)MyPreferedEncodingCodePage);
                if (detected.Length > 0)
                    return detected[0];
                return Encoding.GetEncoding(MyPreferedEncodingCodePage);
            }
            catch(COMException)
            {
                // return default codepage on error
                return Encoding.GetEncoding(MyPreferedEncodingCodePage);
            }
        }

        /// <summary>
        /// Rerurns up to maxEncodings codpages that are assumed to be apropriate
        /// </summary>
        /// <param name="input">array containing the raw data</param>
        /// <param name="maxEncodings">maxiumum number of encodings to detect</param>
        /// <returns>an array of Encoding with assumed encodings</returns>
        public static Encoding[] DetectInputCodepages(byte[] input, int maxEncodings, uint preferedCodePage)
        {

            if (maxEncodings < 1)
                throw new ArgumentOutOfRangeException("at least one encoding must be returend", "maxEncodings");

            if (input == null)
                throw new ArgumentNullException("input");

            // empty strings can always be encoded as ASCII
            if (input.Length == 0)
                return new Encoding[] { Encoding.ASCII };

            // expand the string to be at least 256 bytes
            if (input.Length < 256)
            {
                byte[] newInput = new byte[256];
                int steps = 256 / input.Length;
                for (int i = 0; i < steps; i++)
                    Array.Copy(input, 0, newInput, input.Length * i, input.Length);

                int rest = 256 % input.Length;
                if (rest > 0)
                    Array.Copy(input, 0, newInput, steps * input.Length, rest);
                input = newInput;
            }

            List<Encoding> result = new List<Encoding>();

            // get the IMultiLanguage" interface
            MultiLanguage.IMultiLanguage3 multilang3 = new MultiLanguage.CMultiLanguageClass();
            if (multilang3 == null)
                throw new System.Runtime.InteropServices.COMException("Failed to get IMultilang3");
            try
            {

                MultiLanguage.DetectEncodingInfo[] detectedEncdings;

                detectedEncdings = new MultiLanguage.DetectEncodingInfo[maxEncodings];
                
                int scores = detectedEncdings.Length;
                int srcLen = input.Length;
               
                // setup options (none)   
                MultiLanguage.MLDETECTCP options = MultiLanguage.MLDETECTCP.MLDETECTCP_NONE;

                // finally... call to DetectInputCodepage
                // get unmanaged arrays
                IntPtr pPrefEncs = Marshal.AllocCoTaskMem(sizeof(uint) * PreferedEncodings.Length);
                if (PreferedEncodings != null)
                    Marshal.Copy(PreferedEncodings, 0, pPrefEncs, PreferedEncodings.Length);

                MultiLanguage.HRESULT hres = MultiLanguage.HRESULT.E_FAIL;


                //we need an array of signed bytes...
                sbyte[] sbInput = null;
                sbInput = new SByte[srcLen];
                for (int i = 0; i < srcLen; ++i)
                {
                    sbInput[i] = (SByte)input[i];
                }

                try
                {
                    hres = multilang3.DetectInputCodepage(
                        options,
                        preferedCodePage,
                        ref sbInput[0],
                        ref srcLen,
                        ref detectedEncdings[0],
                        ref scores
                        );
                }
                catch (COMException exc)
                {
                    MessageBox.Show(exc.Message);
                }


                //hres = multilang3.DetectInputCodepage(
                //    options,
                //    preferedCodePage,
                //    ref input[0],
                //    ref srcLen,
                //    ref detectedEncdings[0],
                //    ref scores
                //    );

                if (hres != MultiLanguage.HRESULT.S_OK)
                {
                    MessageBox.Show("Error 3 ! HRESULT=" + hres.ToString());
                }
                
                // get result
                if (scores > 0)
                {
                    for (int i = 0; i < scores; i++)
                    {
                        // add the result
                        result.Add(Encoding.GetEncoding((int)detectedEncdings[i].nCodePage));
                    }
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(multilang3);
            }
            // nothing found
            return result.ToArray();
        }


        /// <summary>
        /// Opens a text file and returns the content 
        /// encoded in the most probable encoding
        /// </summary>
        /// <param name="path">path to the souce file</param>
        /// <returns>the text content of the file</returns>
        public static string ReadTextFile(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");

            using (Stream fs = File.Open(path, FileMode.Open))
            {
                byte[] rawData = new byte[fs.Length];
                Encoding enc = DetectInputCodepage(rawData);
                return enc.GetString(rawData);
            }
        }

        /// <summary>
        /// Returns a stream reader for the given
        /// text file with the best encoding applied
        /// </summary>
        /// <param name="path">path to the file</param>
        /// <returns>a StreamReader for the file</returns>
        public static StreamReader OpenTextFile(string path)
        {
            if (path == null)
                throw new ArgumentNullException("path");
            return OpenTextStream(File.Open(path, FileMode.Open));
        }

        /// <summary>
        /// Creates a stream reader from a stream and detects
        /// the encoding form the first bytes in the stream
        /// </summary>
        /// <param name="stream">a stream to wrap</param>
        /// <returns>the newly created StreamReader</returns>
        public static StreamReader OpenTextStream(Stream stream)
        {
            // check stream parameter
            if (stream == null)
                throw new ArgumentNullException("stream");
            if (!stream.CanSeek)
                throw new ArgumentException("the stream must support seek operations","stream");
            
            // assume default encoding at first place
            Encoding detectedEncoding = Encoding.Default;

            // seek to stream start
            stream.Seek(0, SeekOrigin.Begin);

            // buffer for preamble and up to 512b sample text for dection
            byte[] buf = new byte[System.Math.Min(stream.Length, 512)];

            stream.Read(buf, 0, buf.Length);
            detectedEncoding = DetectInputCodepage(buf);
            // seek back to stream start
            stream.Seek(0, SeekOrigin.Begin);


            return new StreamReader(stream,detectedEncoding);

        }

        public static Encoding FindBestEncodingForFile(string file )
        {

            Encoding targetEncoding;
            Byte[] fileContent;
            fileContent = System.IO.File.ReadAllBytes(file);
            targetEncoding = EncodingTools.DetectInputCodepage(fileContent);
            return targetEncoding;
        }

        public static Encoding FindBestEncodingForString(string String)
        {
            byte[] rawData = new byte[String.Length];
            return DetectInputCodepage(rawData);
        }

        public static string EncodeString(string SourceString, Encoding senc, Encoding denc)
        {
            ////get a byte pointer To the source data
            //Byte[] bsourcedata = senc.GetBytes(SourceString);

            ////Encode the data To destination code page/charset
            //Byte[] b = System.Text.Encoding.Convert(senc, denc, bsourcedata);

            ////return the converted string
            //return denc.GetString(b);
            if ((SourceString == null) || (SourceString.Length == 0))
            {
                return String.Empty;
            }
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                byte[] encoded = senc.GetBytes(SourceString);
                // preamble?
                byte[] preamble = senc.GetPreamble();

                // Make sure a preamble was returned 
                // and is large enough to containa BOM.
                if (preamble.Length >= 2)
                {
                    ms.Write(preamble, 0, preamble.Length);
                }

                ms.Write(encoded, 0, encoded.Length);

                ms.Position = 0;
                byte[] rawData = ms.ToArray();
                return denc.GetString(rawData);
            }
        }

        public static string AutoDecodeString(string SourceString)
        {
            if ((SourceString == null) || (SourceString.Length == 0))
            {
                return String.Empty;
            }
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                Encoding srcEnc = EncodingTools.GetMostEfficientEncoding(SourceString);

                //MessageBox.Show(srcEnc.EncodingName);

                byte[] encoded = srcEnc.GetBytes(SourceString);
                // preamble?
                byte[] preamble = srcEnc.GetPreamble();

                // Make sure a preamble was returned 
                // and is large enough to containa BOM.
                if (preamble.Length >= 2)
                {
                    ms.Write(preamble, 0, preamble.Length);
                }

                ms.Write(encoded, 0, encoded.Length);

                ms.Position = 0;
                Encoding targetEncoding;
                byte[] rawData = ms.ToArray();
                try
                {
                    targetEncoding = EncodingTools.DetectInputCodepage(rawData);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    targetEncoding = Encoding.GetEncoding(MyPreferedEncodingCodePage);
                }
                return targetEncoding.GetString(rawData);
            }
        }
    }  
}
