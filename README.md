WcfClean
========

Utility to cleanup .Net WCF/Web Services generated classes.

When you add a Web Service to an ASP.Net or other .Net project in Visual Studio 2012, behind the scenes it adds a massive class file called References.cs, which contains all the generated WCF classes for speaking with that Web Service.

Although it's generated code, it can be helpful to clean it up a bit to make it more readable so you can scan for certain properties or methods you need. For example, the cleaner tool can cleanup namespace references into using statements at the top of the file, and convert long-hand properties into short-hand, which makes it a bit easier to scan the file for parts of the generated classes.

In addition, when Microsoft moved from "Web Services" to "Windows Communication Foundation," one of the main changes they made was to make all Optional properties on an object expose 2 properties: The property itself and a *Specified property, like:

    string Name
    bool NameSpecified

For these optional properties, if you set the property without setting the Specified flag the original property is treated as not set, and not sent over the web service - not very intuitive.

This cleaning tool can modify the Setters of these properties to implicity switch the Specified flag to true when you assign a value to the relevant property.

Although the file is generated code, there's not much harm in applying this tool to it - you can always just update the reference which will regenerate the code, and if you like, run this on it again.

The cleaner tool has some known issues:

It currently fails to parse private methods on generated Interfaces - they are lost in the translation. You can presently workaround this by manually copying these over if there are a few; I do intend to fix this bug in the future.

It misses some namespaces it could have cleaned up, so for example you'll still see System.Text.StringBuilder in some places instead of just StringBuilder.