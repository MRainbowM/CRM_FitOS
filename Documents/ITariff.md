[Назад](./API.md)

## Описание интерфейса ITariff

Интерфейс предназначен для работы с методами класса Tariff

### Реализация интерфейса

+ **+Add**(Name:string, Duration:int, TotalCost:float, StartDate:DateTime, DateRemoved:DateTime) : int - Добавить новый тариф;
	* Name - наименование тарифа;
	* Duration - длительность тарифа;
	* TotalCost - стоимость тарифа;
	* StartDate - дата начала продаж тарифа;
	* DateRemoved - дата окончания продаж тарифа;

+ **+GetServices**(ID : int) : List<Service> - показать услуги по тарифу;
	* ID - номер тарифа в БД;

+ **+Del**(ID : int) : bool – функция удаления тарифа (Присвоение статуса «удаленный»);
	* ID - номер тарифа в БД;

+ **+Save**(Name:string, Duration:int, TotalCost:float, StartDate:DateTime, DateRemoved:DateTime) : bool – функция сохранения изменений;
	* Name - наименование тарифа;
	* Duration - длительность тарифа;
	* TotalCost - стоимость тарифа;
	* StartDate - дата начала продаж тарифа;
	* DateRemoved - дата окончания продаж тарифа.

+ **+GetAll**() : List<Tariff> - вывести список всех тарифов;

+ **+FindTarrifsByID**(ID : int) : Tariff - найти тариф по ID;
	* ID - номер тарифа в БД;

+ **+AddServiceInTariff**(IDService : int, IDTariff : int, Periodicity : int, Amount : int) : bool - добавить услугу в тариф.
	* IDService - номер услуги в БД;
	* IDTariff - номер тарифа в БД;
	* Periodicity - переодичность услуги;
	* Amount - количество услуги в тарифе.

## Описание класса Tariff

Класс позволяет работать с тарифами.

### Атрибуты класса Tariff

* **-ID** : Int - номер тарифа в БД;
* **-Name** : String - наименование тарифа;
* **-Duration** : Int - длительность тарифа;
* **-Time** : Dictoinary<DateTime, Bool> - время посещения по тарифу;
* **-TotalCost** : Float - стоимость тарифа;
* **-ExpirationDate** : DateTime - дата окончания продаж тарифа;
* **-StartDate** : DateTime - дата начала продаж тарифа;
* **-DateRemoved** : DateTime - дата удаления;
* **-AmountService** : Dictionary<IDService(int), int> - список услуг и их количество по тарифу;
* **-PeriodicityService** : Dictionary<IDService(int), int> - периодичность оказания услуги по тарифу.

[Назад](./API.md)