SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319
%CSCPATH%\csc /reference:bin/Newtonsoft.Json.dll /reference:bin/RestSharp.dll /target:library /out:bin/Khipu.dll /recurse:src\*.cs /doc:bin/Khipu.xml

