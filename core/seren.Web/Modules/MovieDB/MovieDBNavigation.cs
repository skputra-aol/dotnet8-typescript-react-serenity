using Serenity.Navigation;
using MyPages = seren.MovieDB.Pages;

[assembly: NavigationMenu(6000, "MovieDB Root", icon: "fa-film")]
[assembly: NavigationLink(6001, "MovieDB Root/Movie Tree1",
    typeof(MyPages.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(6002, "MovieDB Root/Movie Tree2",
        typeof(MyPages.MoviePage), icon: "fa-firefox")]
[assembly: NavigationLink(6100, "MovieDB Root2", typeof(MyPages.MoviePage), icon: "fa-film")]
