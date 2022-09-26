using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Naterial
{
    /// <summary>
    /// Provides methods for theming.
    /// </summary>
    public static class ThemeHelper

    {
        /// <summary>
        /// Gets or sets a collection of resource dictionaries URIs associated with the key used for theming.
        /// </summary>
        /// <remarks>
        /// The <see cref="BaseTheme" /> elements are set by default.
        /// </remarks>
        public static IDictionary<object, Uri> ThemeDictionaries { get; set; } = new Dictionary<object, Uri>
        {
            { BaseTheme.Light, new Uri("pack://application:,,,/Naterial;component/Themes/Light.xaml") },
            { BaseTheme.Dark, new Uri("pack://application:,,,/Naterial;component/Themes/Dark.xaml") }
        };


        /// <summary>
        /// Sets the resource dictionary by specified theme key.
        /// </summary>
        /// <param name="dict">
        /// The resource dictionary to set theme.
        /// </param>
        /// <param name="key">
        /// The theme key from the <see cref="ThemeDictionaries" />.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// The <paramref name="dict" /> or <paramref name="key" /> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The theme key not found in the <see cref="ThemeDictionaries" />.
        /// </exception>
        public static void SetTheme(ResourceDictionary dict, object key)
        {
            if (dict == null)
            {
                throw new ArgumentNullException(nameof(dict));
            }
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (!ThemeDictionaries.ContainsKey(key))
            {
                throw new ArgumentException($"The given theme key was not defined. Key: '{ key }'.");
            }

            ResourceDictionary actualTheme = FindThemeOrNull(dict, ThemeDictionaries.Values);

            // Before removing the old resource dictionary, you need to add a new one, otherwise decrease performance because warnings for missing
            // resources are created.
            dict.MergedDictionaries.Add(new ResourceDictionary { Source = ThemeDictionaries[key] });

            if (actualTheme != null)
            {
                dict.MergedDictionaries.Remove(actualTheme);
            }
        }


        private static ResourceDictionary FindThemeOrNull(ResourceDictionary root, ICollection<Uri> uries)
        {
            return root.MergedDictionaries.FirstOrDefault(md => md.Source != null &&
                                                                md.Source.IsAbsoluteUri &&
                                                                uries.Contains(md.Source));
        }
    }
}
