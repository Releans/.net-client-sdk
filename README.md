# Getting started

The Releans SDK enables developers to use Releans Services in their code. You can get started in minutes.

## How to Build

The Releans SDK code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (Releans.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The Releans library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Releans library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

### 3. Add reference of the library project

In order to use the Releans library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Releans.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```Releans.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Releans-CSharp&workspaceName=Releans&projectName=Releans.Standard)

## How to Test

The Releans SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

ReleansClient client = new ReleansClient(oAuthAccessToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [MessageController](#message_controller)
* [SenderController](#sender_controller)
* [BalanceController](#balance_controller)

## <a name="message_controller"></a>![Class: ](https://apidocs.io/img/class.png "Releans.Controllers.MessageController") MessageController

### Get singleton instance

The singleton instance of the ``` MessageController ``` class can be accessed from the API Client.

```csharp
MessageController message = client.Message;
```

### <a name="get_all_messages"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.MessageController.GetAllMessages") GetAllMessages

> List all messages sent by the account.


```csharp
Task<dynamic> GetAllMessages()
```

#### Example Usage

```csharp

dynamic result = await message.GetAllMessages();

```


### <a name="get_price_of_message"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.MessageController.GetPriceOfMessage") GetPriceOfMessage

> Return cost of sending a message to the number.


```csharp
Task<string> GetPriceOfMessage(string mobileNumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mobileNumber |  ``` Required ```  | Mobile number you want to know the price of sending a message. |


#### Example Usage

```csharp
string mobileNumber = "mobileNumber";

string result = await message.GetPriceOfMessage(mobileNumber);

```


### <a name="get_view_message"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.MessageController.GetViewMessage") GetViewMessage

> Return the details of the message.


```csharp
Task<dynamic> GetViewMessage(string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | Id of the message you need to return its details. |


#### Example Usage

```csharp
string id = "id";

dynamic result = await message.GetViewMessage(id);

```


### <a name="create_send_sms_message"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.MessageController.CreateSendSMSMessage") CreateSendSMSMessage

> Send a single message.


```csharp
Task<string> CreateSendSMSMessage(string senderId, string mobileNumber, string message)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| senderId |  ``` Required ```  ``` DefaultValue ```  | Sender id to send the message from. |
| mobileNumber |  ``` Required ```  ``` DefaultValue ```  | The mobile number supposed to receive the message. |
| message |  ``` Required ```  ``` DefaultValue ```  | Message text. |


#### Example Usage

```csharp
string senderId = "sender-id";
string mobileNumber = "mobile-number";
string message = "message";

string result = await message.CreateSendSMSMessage(senderId, mobileNumber, message);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="sender_controller"></a>![Class: ](https://apidocs.io/img/class.png "Releans.Controllers.SenderController") SenderController

### Get singleton instance

The singleton instance of the ``` SenderController ``` class can be accessed from the API Client.

```csharp
SenderController sender = client.Sender;
```

### <a name="get_sender_name_details"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.SenderController.GetSenderNameDetails") GetSenderNameDetails

> Return the details of the sender name.


```csharp
Task<dynamic> GetSenderNameDetails(string id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  ``` DefaultValue ```  | The sender id you want its details |


#### Example Usage

```csharp
string id = "sender-id";

dynamic result = await sender.GetSenderNameDetails(id);

```


### <a name="create_sender_name"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.SenderController.CreateSenderName") CreateSenderName

> Create a new sender id to send messages using it


```csharp
Task<string> CreateSenderName(string senderName)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| senderName |  ``` Required ```  ``` DefaultValue ```  | Name you want to register as Sender Name |


#### Example Usage

```csharp
string senderName = "Your sender name";

string result = await sender.CreateSenderName(senderName);

```


### <a name="get_all_senders"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.SenderController.GetAllSenders") GetAllSenders

> List all senders names associated with the account


```csharp
Task<dynamic> GetAllSenders()
```

#### Example Usage

```csharp

dynamic result = await sender.GetAllSenders();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="balance_controller"></a>![Class: ](https://apidocs.io/img/class.png "Releans.Controllers.BalanceController") BalanceController

### Get singleton instance

The singleton instance of the ``` BalanceController ``` class can be accessed from the API Client.

```csharp
BalanceController balance = client.Balance;
```

### <a name="get_balance"></a>![Method: ](https://apidocs.io/img/method.png "Releans.Controllers.BalanceController.GetBalance") GetBalance

> Get your available balance


```csharp
Task<string> GetBalance()
```

#### Example Usage

```csharp

string result = await balance.GetBalance();

```


[Back to List of Controllers](#list_of_controllers)



