using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace App8
{
    public class ThicknessConverter : IValueConverter
    {
        public object Convert( object value, Type targetType, object parameter, string language )
        {
            var MyValue = value ?? 1;
            var result = new Thickness( int.Parse( MyValue.ToString()));
            return result;
        }

        public object ConvertBack( object value, Type targetType, object parameter, string language )
        {
            throw new NotImplementedException();
        }
    }
}
