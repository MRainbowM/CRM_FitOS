[Назад](./API.md)

## Описание интерфейса IService

Интерфейс предназначен для работы с методами класса Service

### Реализация интерфейса

+ **+Add**(Name:string, Cost:int, Comment:string) : int– функциядобавленияуслугивБД;
	* Name - наименование услуги;
	* Cost - стоимость услуги;
	* Comment - комментарий об услуге;

+ **+Del**(ID : int) : bool – функция удаления услуги (Присвоение статуса «удаленная»);
	* ID - номер услуги в БД;

+ **+Save**(Name:string, Cost:int, Comment:string) : bool – функциясохраненияизменений;
	* Name - наименование услуги;
	* Cost - стоимость услуги;
	* Comment - комментарий об услуге;

+ **+GetAll**() : List<[Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service)> - вывести список всех услуг;

+ **+GetTrainers**(IDServise : int) : List<[Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer)> - вывести всех тренеров услуги;
	* IDServise - номер услуги в БД;

+ **+FindServiceByID**(ID : int) : [Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service) - поискуслугипо ID;
	* ID - номер услуги в БД;

+ **+GetBalanceService**(IDCard : int) : Dictionary<[Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service), int> - показать баланс карты, то есть количество услуги на карте;
	* IDCard - номер карты пользователя в БД;

+ **+GetBalanceFrost**(IDCard : int) : Dictionary<[Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service), int> - показать количество дней заморозки;
	* IDCard - номер карты пользователя в БД;

## Описание класса Service

Данный класс позволяет работать со списком услуг. 

### Атрибуты класса Service

* **ID** : Int - номер услуга в БД;
* **Name** : String - наименование услуги;
* **Cost** : Int - стоимость услуги;
* **Comment** : String - комментарий об услуге;
* **Room** : List<[Room](https://github.com/MRainbowM/CRM_FitOS/blob/master/IRoom.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-room)> - списо комнат, в которых проводится услуга.
* **State** : Bool - статус услуги: удаленная или нет.

[Назад](./API.md)