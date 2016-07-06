using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.UserProfile;
using Windows.UI.Xaml.Data;

namespace App8
{
    public class FloatConverter : IValueConverter
    {
        public string MyLanguage
        {
            get;
            set;
        }

        public object Convert( object value, Type targetType, object parameter, string language )
        {
            MyLanguage = string.IsNullOrWhiteSpace( language ) ? MyLanguage : language;
            MyLanguage = string.IsNullOrWhiteSpace( MyLanguage ) ? GlobalizationPreferences.HomeGeographicRegion : MyLanguage;

            var floatValue = float.Parse( value.ToString(), new CultureInfo( MyLanguage ));
            var result = string.Format( new CultureInfo( MyLanguage ), "{0:F2}", floatValue );
            return result;
        }

        public object ConvertBack( object value, Type targetType, object parameter, string language )
        {
            MyLanguage = string.IsNullOrWhiteSpace( language ) ? MyLanguage : language;
            MyLanguage = string.IsNullOrWhiteSpace( MyLanguage ) ? GlobalizationPreferences.HomeGeographicRegion : MyLanguage;

            var floatString = value as string;
            var result = float.Parse( floatString, new CultureInfo( MyLanguage ) );
            return result;
        }
    }
}
