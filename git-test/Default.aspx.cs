using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace git_test
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //教材实例
            String[] array = new string[5];
            array[0] = "水调歌头，明月几时有<br>";
            array[1] = "宋代：苏轼 许若辰</br>";
            array[2] = "丙辰中秋，欢饮达旦，大醉，作此篇，兼怀子由</br>";
            array[3] = "明月几时有？把酒问青天。不知天上宫阙，今夕是何年。我欲乘风归去，又恐琼楼玉宇，高处不胜寒。起舞弄清影，何似在人间。</br>";
            array[4] = "转朱阁，低绮户，照无眠。不应有恨，何事长向别时圆？人有悲欢离合，月有阴晴圆缺，此事古难全。但愿人长久，千里共婵娟。</br>";
            Response.Write(array[0]);
            Response.Write(array[1]);
            Response.Write(array[2]);
            Response.Write(array[3]);
            Response.Write(array[4]);
        }
    }
}