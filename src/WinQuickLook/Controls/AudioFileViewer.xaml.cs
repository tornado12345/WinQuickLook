﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WinQuickLook.Controls
{
    public partial class AudioFileViewer
    {
        public AudioFileViewer()
        {
            InitializeComponent();
        }
        
        public Uri Source
        {
            get { return (Uri)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(Uri), typeof(AudioFileViewer), new PropertyMetadata(null));

        public BitmapSource Thumbnail
        {
            get { return (BitmapSource)GetValue(ThumbnailProperty); }
            set { SetValue(ThumbnailProperty, value); }
        }
        
        public static readonly DependencyProperty ThumbnailProperty =
            DependencyProperty.Register("Thumbnail", typeof(BitmapSource), typeof(AudioFileViewer), new PropertyMetadata(null));
    }
}