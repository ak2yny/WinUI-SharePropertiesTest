# Test App for Shared Properties with .Net

While developing a WinUI project with multiple pages (NavigationView) I found that I didn't know how to properly share the data between each page. Data binding works with non-static properties, while sharing data in different pages/classes works with static properties.
Learning about WinUI, I quickly learned about [MVVM](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm) ([data binding examples](https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/mvvm)) and ended up having the most success with it, except that I didn't know how to do this the right way. Shared properties always stayed on the same page.

So, I created this repo to share my non-working code on [StackOverflow](https://stackoverflow.com/questions/76563365/winui-c-how-to-share-data-between-pages-the-proper-way). There is already a working solution, but this project will be left in the non-working state in case others want to learn something from it.

For those curious: Dependency Injection apparently is another working solution, but I can't give a link to a good example, sorry.
