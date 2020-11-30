# A Quick Way to Read XML Files with a Definition File into DotNetCore Objects

This is a short article shows how to import complex XML/XSD files into C# classes in DotNetCore.  I've it because there's so much junk out there about how to (but mostly how not) do it.

To demonstrate the process I'll be importing GPX files.  These are XML formatted files.  The detailed definition is [here](https://www.topografix.com/GPX/1/1/).

One look will tell you how complex and detailed the GPX standard is.  Manually building classes to handle all the possibilities would be a lengthy process.  Luckily Microsoft provide a tool for doing just that, buried in the Windows SDK.

Lets get started:

1. Set up a bare bones DotNetCore console project (if you use Visual Studio the IDE will do some clever associations for you).
2. Get the XSD file for the format and add it to a subfolder, in this case *Gpx* - [GPX.xsd](https://www.topografix.com/GPX/1/1/gpx.xsd).
3. Find XSD.exe.  It's the tool I talked about above.  It's in the Windows SDK - at the moment in my case its in *C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools*
4. Open a console/powershell window, change to it'd directory and run it against the xsd file:

```ps
.\xsd.exe "D:\Documents\GitHub\GPXReader\Gpx\gpx.xsd" /c /outputdir:"D:\Documents\GitHub\CEC.OSM\CEC.OSM\Data\Gpx"
```

The result should be (I've added the separation ============= to make it clearer):

```ps
PS C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools> .\xsd.exe "D:\Documents\GitHub\GPXReader\Gpx\gpx.xsd" /c /outputdir:"D:\Documents\GitHub\CEC.OSM\CEC.OSM\Data\Gpx"

==========================================================
Microsoft (R) Xml Schemas/DataTypes support utility
[Microsoft (R) .NET Framework, Version 4.8.3928.0]
Copyright (C) Microsoft Corporation. All rights reserved.
Writing file 'D:\Documents\GitHub\GPXReader\Gpx\gpx.cs'.

===========================================================
PS C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools>
```


