using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class CLeague
    {
         
    }
    class LeagueBinaryFile
    {
       public class FILE_INFO 
       {
		    public static int cFileVersion = 1;
		    public static int cHeaderSize = 89;
		    public static int cTeamSize = 42;
		    public static int cMatchSize = 9;
		    public static int cLeagueNameChars = 16;
		    public static int cTeamNameChars = 10;
	    }

       public static int byteArrayToInt(byte[] b)
       {
           return byteArrayToInt(b, 0);
       }

        public static int byteArrayToInt(byte[] b, int offset) 
        {
        int value = 0;
        for (int i = 0; i < 4; i++) {
            int shift = (4 - 1 - i) * 8;
            value += (b[i + offset] & 0x000000FF) << shift;
        }
        return value;
        }

        public static  int byteArrayToInt2(byte [] b) 
        {
            return (b[0] << 24)
                    + ((b[1] & 0xFF) << 16)
                    + ((b[2] & 0xFF) << 8)
                    + (b[3] & 0xFF);
        }
        public static  int unsignedShortToInt(byte[] b) 
        {
            int i = 0;
            i |= b[0] & 0xFF;
            i <<= 8;
            i |= b[1] & 0xFF;
            return i;
        }

        public static int toInt(byte[] bytes)
        {
            int result = 0;
            for (int i = 0; i < 4; i++)
            {
                result = (result << 8) - Byte.MinValue + (int)bytes[i];
            }
            return result;
        }
        public static int bytesToInt16(byte[] buffer, int byteOffset,Boolean bigEndian)
        {
            return bigEndian ?
            ((buffer[byteOffset] << 8) | (buffer[byteOffset + 1] & 0xFF)) :

            ((buffer[byteOffset + 1] << 8) | (buffer[byteOffset] & 0xFF));
        }

        public String m_cFilename;
        public String m_sPath;  
    }
}
