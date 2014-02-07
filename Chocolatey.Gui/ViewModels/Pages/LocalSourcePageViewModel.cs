﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Chocolatey.Gui.Base;
using Chocolatey.Gui.Models;
using Chocolatey.Gui.ViewModels.Items;

namespace Chocolatey.Gui.ViewModels.Pages
{
    public class LocalSourcePageViewModel : ObservableBase, ILocalSourcePageViewModel
    {
        private ObservableCollection<PackageViewModel> _packageViewModels; 
        public ObservableCollection<PackageViewModel> Packages
        {
            get { return _packageViewModels; }
            set { SetPropertyValue(ref _packageViewModels, value); }
        }

        public LocalSourcePageViewModel()
        {
            Packages = new ObservableCollection<PackageViewModel>
            {
                new PackageViewModel
                {
                    Title = "Test 1", 
                    Version = new SemanticVersion(0,1,0,1337),
                    Authors = "Richard Simpson", 
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ipsum risus, sodales vel neque eget, porta egestas lorem. Nam id dui quam. Nam at ligula ultricies, dignissim dolor ut, consectetur nisl. In semper elit non nunc porttitor faucibus. Quisque vestibulum varius ante, et ultrices orci feugiat vel. Nulla aliquam augue vel lacus tincidunt, ultricies pharetra nibh porttitor. Praesent porttitor malesuada velit, a molestie nisl faucibus aliquet. Curabitur pellentesque nisi ut magna vestibulum aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aliquam feugiat dolor at lectus dignissim, at faucibus leo molestie.",
                    DownloadCount = 1337,
                    Tags = "yolo awesome that stuff"
                },
                new PackageViewModel
                {
                    Title = "Test 2", 
                    Version = new SemanticVersion(0,1,0,1337),
                    Authors = "Richard Simpson", 
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ipsum risus, sodales vel neque eget, porta egestas lorem. Nam id dui quam. Nam at ligula ultricies, dignissim dolor ut, consectetur nisl. In semper elit non nunc porttitor faucibus. Quisque vestibulum varius ante, et ultrices orci feugiat vel. Nulla aliquam augue vel lacus tincidunt, ultricies pharetra nibh porttitor. Praesent porttitor malesuada velit, a molestie nisl faucibus aliquet. Curabitur pellentesque nisi ut magna vestibulum aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aliquam feugiat dolor at lectus dignissim, at faucibus leo molestie.",
                    DownloadCount = 1337,
                    Tags = "yolo awesome that stuff"
                },
                new PackageViewModel
                {
                    Title = "Test 3", 
                    Version = new SemanticVersion(0,1,0,1337),
                    Authors = "Richard Simpson", 
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ipsum risus, sodales vel neque eget, porta egestas lorem. Nam id dui quam. Nam at ligula ultricies, dignissim dolor ut, consectetur nisl. In semper elit non nunc porttitor faucibus. Quisque vestibulum varius ante, et ultrices orci feugiat vel. Nulla aliquam augue vel lacus tincidunt, ultricies pharetra nibh porttitor. Praesent porttitor malesuada velit, a molestie nisl faucibus aliquet. Curabitur pellentesque nisi ut magna vestibulum aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aliquam feugiat dolor at lectus dignissim, at faucibus leo molestie.",
                    DownloadCount = 1337,
                    Tags = "yolo awesome that stuff"
                },
                new PackageViewModel
                {
                    Title = "Test 4", 
                    Version = new SemanticVersion(0,1,0,1337),
                    Authors = "Richard Simpson", 
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ipsum risus, sodales vel neque eget, porta egestas lorem. Nam id dui quam. Nam at ligula ultricies, dignissim dolor ut, consectetur nisl. In semper elit non nunc porttitor faucibus. Quisque vestibulum varius ante, et ultrices orci feugiat vel. Nulla aliquam augue vel lacus tincidunt, ultricies pharetra nibh porttitor. Praesent porttitor malesuada velit, a molestie nisl faucibus aliquet. Curabitur pellentesque nisi ut magna vestibulum aliquam. Interdum et malesuada fames ac ante ipsum primis in faucibus. Aliquam feugiat dolor at lectus dignissim, at faucibus leo molestie.",
                    DownloadCount = 1337,
                    Tags = "yolo awesome that stuff"
                },
            };
        }
    }
}