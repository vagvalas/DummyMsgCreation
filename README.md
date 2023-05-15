# DummyMsgCreation
Need for one-time to create mutliple MSG files, which is used for Outlook mails, for receiver and sender, on many different dates
It is some-how Generalized now.
You can customize more and more things.

# Prerequests:
```
You need to create a WindowsFormApp .NET 6.0 (long-term supported)
You need to add this package https://github.com/Sicos1977/MsgKit to your Project, via NuGet package manager 
or using" Install-Package MsgKit " (It may be also included automatically)
```
# Usage
1. You need a CSV with this form
```
First column has a value "company name" (it can be anything, and can be used in main body as {COMPANY}
Second column has a value "email" (this is used to represent the SENDER of EACH email)
Third column has a value "name" (it can be anything, and can be used in main body as {NAME}
```
![εικόνα](https://github.com/vagvalas/DummyMsgCreation/assets/19560574/a66ceabb-8088-4238-be16-403dbed090fb)
2. Select start and end date so the program to understand which dates needs to be generated
![εικόνα](https://github.com/vagvalas/DummyMsgCreation/assets/19560574/367c379a-5527-4e73-8c25-5cdfbd320852)

3. In the subjuct field, (optionally you can set a subject)
4. In the To/Recipient field you need to specify the receiver of email. 

# Final thoughts
to be written
