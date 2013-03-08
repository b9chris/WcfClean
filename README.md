WcfClean
========

Utility to cleanup .Net WCF/Web Services generated classes.

When you add a Web Service to an ASP.Net or other .Net project in Visual Studio 2012, behind the scenes it adds a massive class file called References.cs, which contains all the generated WCF classes for speaking with that Web Service.

It can be helpful to clean it up a bit to make it more readable so you can scan for certain properties or methods you need, and to automate some common use cases.

##Features##

####Cleanup Namespaces####
The cleaner tool can cleanup namespace references into using statements at the top of the file.

####Convert Properties to Shorthand####
For some reason the generated code always uses long-hand properties like:

    private String myPropertyName;

    // More private property fields here

    public String MyPropertyName
    {
        get
        {
            return myPropertyName;
        }
        set
        {
            myPropertyName = value;
        }
    }

If you like to scan code quickly to determine what's possible in it these are a lot of clutter - the tool can shorten them to:

    public String MyPropertyName { get; set; }

####Automate Set of *Specified Flags####
When Microsoft moved from "Web Services" to "Windows Communication Foundation," one of the main changes they made was to make all Optional properties on an object expose 2 properties: The property itself and a *Specified property, like:

    string Name
    bool NameSpecified

For these optional properties, if you set the property without setting the Specified flag the original property is treated as not set, and not sent over the web service - not very intuitive. This can be useful in some advanced scenarios, but in many simple use cases these are just an extra burden:

[http://social.msdn.microsoft.com/Forums/en-US/wcf/thread/a1bca402-cbe1-4233-8eb3-ce01b8cefcd4/](http://social.msdn.microsoft.com/Forums/en-US/wcf/thread/a1bca402-cbe1-4233-8eb3-ce01b8cefcd4/)

[http://stackoverflow.com/questions/1680356/wcf-service-proxy-not-setting-fieldspecified-property](http://stackoverflow.com/questions/1680356/wcf-service-proxy-not-setting-fieldspecified-property)

This cleaning tool can modify the Setters of these properties to implicity switch the Specified flag to true when you assign a value to the relevant property.

## Usage ##
For Windows users there's a Project called WcfClean included that runs a Windows Forms app to clean up a References.cs file. For those wanting to use this from a command-line etc, all the functionality really lives in Brass9.WcfCleanLib, and it should be trivial to tie into its commands for a console app or Mono forms app, etc.

Eventually this will support a config file or UI for configuration - for now there's just a Config object you need to switch some values around on if you want to change what actions the cleaner takes and what it doesn't.

If you're using the WcfClean Windows Forms app, you can add a Config object on line 82 with the desired settings. You can see the default settings it uses in Brass9.WcfCleanLib.WcfCleanerOptions.

##Known Issues##

Currently fails to parse private methods on generated Interfaces - they are lost in the translation. You can presently workaround this by manually copying these over if there are a few; I do intend to fix this bug in the future.

Misses some namespaces it could have cleaned up, so for example you'll still see System.Text.StringBuilder in some places instead of just StringBuilder.

The UseShorthandProperties setting is currently ignored and treated as always true.