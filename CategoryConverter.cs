using Products;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Products
{
    public class CategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ProductCategories)value)
            {
                case ProductCategories.Food:
                    return "Еда";
                case ProductCategories.Appliances:
                    return "Бытовые приборы";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}