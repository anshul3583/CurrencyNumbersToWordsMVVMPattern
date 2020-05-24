# CurrencyNumbersToWordsMVVMPattern
WPF project to Convert - Currency Numbers to words, using MVVM pattern
Task - Write a program which converts currency (dollars) from numbers into word presentation.
Solution – I have added the solution to my GitHub repo -  can be downloaded from below links.
WCF Service - https://github.com/anshul3583/CurrencyNumbersToWordsWCFSvc
WPF UI -      https://github.com/anshul3583/CurrencyNumbersToWordsMVVMPattern

To run the Application – please download WCF Service and WPF client code and run both solutions, once the service is running locally – please make sure app config file has correct refence as shown below – (update endpoints accordingly).

 
Client side of the application has been created with WPF (.net frame work 4.6). I have implemented MVVM (ModelViewViewModel) pattern with PrismUnity version 7.2.0.1422.
Server Side – WCF service contains the parsing and conversion logic. MS unit test project has been added to the solution, with couple unit tests for the main conversion method.
WCF Service url – http://localhost:50134/Service.svc?singleWsdl 


I have used regex101.com to make sure, regex for validation is working which can also be accessed via -
https://regex101.com/r/uSsKNg/2
 
