Xamarin.Forms 4.0.0.48294 seems to have an iOS renderer bug when CollectionView or ListView is the content of a Shell top tab. The CollectionView or ListView appears to have incorrect top insets that place the top of the scroll view behind (z-index beneath) the tabs. The problem seems to only exist on iOS. Android does not have this behavior.

Video of the behavior:
https://www.youtube.com/watch?v=_NuOoiVpHrw