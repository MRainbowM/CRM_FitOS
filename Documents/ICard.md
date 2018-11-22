[Назад](./API.md)

## Описание интерфейса ICard

Интерфейс предназначен для работы с методами класса Card

### Реализация интерфейса

+ **+Add**(IDTariff: int, IDClient: int) : int - Добавить карту;
	* IDTariff - Номер тарифа в БД;
	* IDClient - номер пользователя в БД, владелец карты;

+ **+Del**(ID : int) : bool – функция удаления карты (Присвоение статуса «удаленная»);
	* ID - номер карты в БД;

+ **+Save**(IDTariff: int) : bool – функция сохранения изменений;
	* IDTariff - Номер тарифа в БД;

+ **+GetAll**() : List<[Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card)> - вывести список всех карт;

+ **+FindCardByID**(ID : int) : [Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card) - поискпо ID;
	* ID - номер карты в БД;

+ **+AddVisit**(IDCard : int, IDService : int) : int - добавить посещение;
	* ID - номер карты в БД;
	* IDService - номер услуги в БД;

+ **+DelVisit**(IDCard : int, IDService : int) : bool - удалить посещение;
	* ID - номер карты в БД;
	* IDService - номер услуги в БД;

+ **+FrostCard**(IDCard : int, StartDate : DateTime, EndDate : DateTime) : bool - заморозка карты;
	* ID - номер карты в БД;
	* StartDate - дата начала заморозки;
	* EndDate - дата разморозки.

## Описание класса Card

Класс позволяет работать с картами клиентов. 

### Атрибуты класса Card

* **ID** : Int - номер сарты в БД;
* **Tariff** : [Tariff](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITariff.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-tariff) - тариф карты;
* **State** : Bool - статус карты: удаленная или нет;
* **StateFrost** : Bool - статус заморозки карты.

[Назад](./API.md)