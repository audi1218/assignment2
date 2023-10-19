using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// video game class
namespace VideoGameLab
{
    public  class VideoGame : IComparable<VideoGame>
    {
        //properties
        public string Name { get; set; }
        public string Platform { get; set; }
        public int Year {  get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public double NASales { get; set; }
        public double EUSales { get; set; }
        public double JPSales { get; set; }
        public double OtherSales { get; set; }
        public double GlobalSales { get; set; }

        public int CompareTo(VideoGame other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Platform: {Platform}, Year: {Year}, Genre: {Genre}, Publisher: {Publisher}, NA Sales: {NASales}, EU Sales: {EUSales}, JP Sales: {JPSales}, OtherSales: {OtherSales}, Global Sales: {GlobalSales}";
        }
    }
}
