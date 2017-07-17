# Augmntr.IO.Compression
This project contains the portions of the .NET Framework IO.Compression namespace that are not present in the implementation shipped with Unity as of 2017.1.

Most notable is System.IO.Compression.ZipArchive and its supporting classes.

Project is a direct copy from the DotNet Foundation's [corefx repo](https://github.com/dotnet/corefx/tree/master/src/System.IO.Compression).

Changes were very minimal:
* Namespace change to Augmntr
* Manual creation of "SR" class for error messages strings
* #ifdef out of Begin/End Read/Write functions in DeflateManaged that reled on other helpers

This requires that the Unity Scripting Backend be set to .NET 4.6 Equivalent.

With these additions, that rely on ZipArchive (such as SharpKML) are able to be used with only namespace changes, and projects such as DotNetZip are no longer required.

