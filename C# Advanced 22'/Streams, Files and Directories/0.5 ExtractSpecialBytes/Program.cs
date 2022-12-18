using System.IO;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        { // TODO: write your code here… } } }

            using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (FileStream bytes = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] bufferBytes = new byte[bytes.Length];

                    bytes.Read(bufferBytes, 0, (int)bytes.Length);

                    byte[] bufferImage = new byte[bytes.Length];

                    bytes.Read(bufferImage, 0, (int)bytes.Length);

                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        for (int i = 0; i < bufferImage.Length; i++)
                        {
                            for (int j = 0; j < bufferBytes.Length; j++)
                            {
                                if (bufferImage[i] == bufferBytes[j])
                                {
                                    output.Write(new byte[] { bufferImage[i] });
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

