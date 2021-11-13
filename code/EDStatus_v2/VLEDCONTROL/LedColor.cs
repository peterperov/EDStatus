/* written 2021 by Nereid
  
 Apache 2.0 License
 (see LICENSE file)

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLEDCONTROL
{


    /// <summary>
    /// TODO: need to protect setters 
    /// </summary>
    public class LedColor
    {
        public int red { get; set; } = 0;
        public int green { get; set; } = 0;
        public int blue { get; set; } = 0;

        private int _hash; 

        public static readonly LedColor BLACK = new LedColor(0, 0, 0);
        public static readonly LedColor GRAY = new LedColor(128, 128, 128);
        public static readonly LedColor WHITE = new LedColor(255, 255, 255);
        public static readonly LedColor DARKGREEN = new LedColor(0, 64, 0);

        public LedColor()
        {

        }

        public LedColor(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;


            _hash = red.GetHashCode() ^ green.GetHashCode() ^ blue.GetHashCode(); 
        }


        /// <summary>
        /// 
        /// 3 hex values 
        ///  00 FF FF 
        /// 
        /// </summary>
        /// <param name="str"></param>
        public LedColor(string str)
        {
            var val = str.Split(" ");

            this.red = int.Parse(val[0], System.Globalization.NumberStyles.HexNumber);
            this.green = int.Parse(val[1], System.Globalization.NumberStyles.HexNumber);
            this.blue = int.Parse(val[2], System.Globalization.NumberStyles.HexNumber);

            _hash = red.GetHashCode() ^ green.GetHashCode() ^ blue.GetHashCode();
        }


        public override int GetHashCode()
        {
            return _hash; 
        }

        public override string ToString()
        {
            return "#" + red.ToString("X2") + "/#" + green.ToString("X2") + "/#" + blue.ToString("X2");
        }

        public String AsString()
        {
            return red.ToString("X2") + "/" + green.ToString("X2") + "/" + blue.ToString("X2");
        }


        public System.Drawing.Color ToSystemColor()
        {
            return System.Drawing.Color.FromArgb(red, green, blue);
        }

        public static LedColor FromSystemColor(System.Drawing.Color color)
        {
            return new LedColor(color.R, color.G, color.B);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj.GetType() != typeof(LedColor)) return false;
            LedColor cmp = (LedColor)obj;
            return (this.red == cmp.red && this.green == cmp.green && this.blue == cmp.blue);
        }


/*
        public override int GetHashCode1()
        {
            return red.GetHashCode() + 255 * green.GetHashCode() + 255 * 255 * blue.GetHashCode();
        }
*/
    }
}
