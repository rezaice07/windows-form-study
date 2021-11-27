using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStudy
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            string jsonString = @"
                {""data"":[{""name"":""EO Like 11 - 18 - 2021"",""objective"":""PAGE_LIKES"",""id"":""23849144270930001""},{""name"":""TokenTest"",""objective"":""PAGE_LIKES"",""id"":""23849143895920001""},{ ""name"":""Dalaa Conv 10 - 28 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848981633710001""},{ ""name"":""Dalaa Eng 10 - 26 - 2021"",""objective"":""POST_ENGAGEMENT"",""id"":""23848962890810001""},{ ""name"":""Dalaa Like 10 - 23 - 2121"",""objective"":""PAGE_LIKES"",""id"":""23848944906280001""},{ ""name"":""Dalaa Eng 10 - 22 - 2021"",""objective"":""POST_ENGAGEMENT"",""id"":""23848932524460001""},{ ""name"":""Dalaa Eng. 10 - 7 - 2021"",""objective"":""POST_ENGAGEMENT"",""id"":""23848811727020001""},{ ""name"":""Dalaa Reach 10 - 7 - 2021"",""objective"":""REACH"",""id"":""23848811657620001""},{ ""name"":""Fogg Carousel 09 - 20 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848663427830001""},{ ""name"":""Dalaa Conv 09 - 20 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848661295690001""},{ ""name"":""Fogg 10\u0025 09 - 15 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848625455240001""},{ ""name"":""Fogg Caraousel 09 - 15 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848625320080001""},{ ""name"":""EO Like 09 - 20 - 2021"",""objective"":""PAGE_LIKES"",""id"":""23848555665460001""},{ ""name"":""Fogg combo 2 08 - 28 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848468927990001""},{ ""name"":""Fogg Combo 1 08 - 28 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848468915960001""},{ ""name"":""Fogg Assortment Caraousel 1 08 - 23 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848431619160001""},{ ""name"":""Fogg Caraousel 2 08 - 23 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848431187440001""},{ ""name"":""Fogg Assortment Conv 08 - 23 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848423907270001""},{ ""name"":""Fogg Caraousel Conv 08 - 23 - 2021"",""objective"":""CONVERSIONS"",""id"":""23848423415920001""},{ ""name"":""Dalaa Like 08 - 19 - 2021"",""objective"":""PAGE_LIKES"",""id"":""23848395283900001""},{ ""name"":""Baah 07 - 02 - 2021"",""objective"":""MESSAGES"",""id"":""23848053105820001""},{ ""name"":""Skitto Traffic 06 - 30 - 2021"",""objective"":""LINK_CLICKS"",""id"":""23848034237880001""},{ ""name"":""Skitto 06 - 29 - 2021"",""objective"":""LINK_CLICKS"",""id"":""23848029655670001""},{ ""name"":""Baah 06 - 29 - 2021"",""objective"":""MESSAGES"",""id"":""23848027240140001""},{ ""name"":""Baah 2nd 06 - 28 - 2021"",""objective"":""MESSAGES"",""id"":""23848018793830001""}],""paging"":{ ""cursors"":{ ""before"":""QVFIUnI1blk3bGNBVkFPM2E0bFRJcUF5dVhpbEpTb3NDOEdRTHVzUEZAqdExOYTJOdjVBelAxR1pKR3dDWk9WT2lSc19GREplSW1fNDQxc0RLZAFlPaHFNbGxR"",""after"":""QVFIUkVGbC1CUjc5bnBBc00yQXBra1BRSTY5R2tsd21LbXZAMN056dXhjSDNaNkt0MU9RS2xaLWZA1NDZAySS1vUG4zanFUckQ2Sk5ZAMTZAJRjBPcUxoVFZAXZAXJn""},""next"":""https:\/\/ graph.facebook.com\/ v12.0\/ act_3726616517384239\/ campaigns ? access_token = EAAJRLEg9B8UBAJbeZA9Q3ZCGwdm2Y1EDIZANJc9iZCCYZACEZBL1rSTI6FQZAfXiHEJvddKALEqRZB8RPKomfvwqMs5NFPwTO8HK9Mx2OzA6vsSgkRq3OOIZCMjT99m4DD1tYVGN9ppaoFdt5SfE93yr7a8cmWZBHw5fXFgeU5lUytzP1VTvVQDRxk & fields = name\u00252Cobjective & limit = 25 & after = QVFIUkVGbC1CUjc5bnBBc00yQXBra1BRSTY5R2tsd21LbXZAMN056dXhjSDNaNkt0MU9RS2xaLWZA1NDZAySS1vUG4zanFUckQ2Sk5ZAMTZAJRjBPcUxoVFZAXZAXJn""}}
            ";

            var pocoObject = JsonConvert.DeserializeObject<DemoPocoObject>(jsonString);

            var dataList = new List<DataObject>()
            {
                new DataObject { name = "Select One" }
            };

            dataList.AddRange(pocoObject.data);

            cboData.DataSource = pocoObject.data;
            cboData.DisplayMember = "name";
            cboData.ValueMember = "id";
        }
    }


    public class DemoPocoObject
    {
        public List<DataObject> data { get; set; }
        public PagingObject paging { get; set; }

    }

    public class DataObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string objective { get; set; }
    }

    public class PagingObject
    {
        public CursorsObject cursors { get; set; }
        public string next { get; set; }
    }

    public class CursorsObject
    {
        public string before { get; set; }
        public string after { get; set; }
    }
}
