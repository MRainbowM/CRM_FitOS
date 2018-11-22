[Назад](./API.md)

## Описание интерфейса ISchedule

Интерфейс предназначен для работы с методами класса Schedule

### Реализация интерфейса

+ **+Add**(Trainer : [Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer), Card : [Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card), Service : [Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service), Room : [Room](https://github.com/MRainbowM/CRM_FitOS/blob/master/IRoom.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-room), Date : DateTime) : int - Добавитьзапись;
	* Trainer - экземпляр класса Trainer;
	* Card - экземпляр класса Trainer;
	* Service - экземпляр класса Service;
	* Room - экземпляр класса Room;
	* Date - дата занятия;

+ **+Del**(ID : int) : bool – функция удаления запись (Присвоение статуса «удаленная»);
	* ID - номер записи в БД;

+ **+Save**(Trainer : [Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer), Card : [Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card), Service : [Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service), Room : [Room](https://github.com/MRainbowM/CRM_FitOS/blob/master/IRoom.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-room), Date : DateTime) : bool – функция сохранения изменений;
	* Trainer - экземпляр класса Trainer;
	* Card - экземпляр класса Trainer;
	* Service - экземпляр класса Service;
	* Room - экземпляр класса Room;
	* Date - дата занятия;

+ **+AddFrost**( StartDate : DateTime, EndDate : DateTime, IDCard:int) : bool - заморозить карту;
	* ID - номер карты в БД;
	* StartDate - дата начала заморозки;
	* EndDate - дата разморозки;

+ **+GetAll()** : List<[Schedule](https://github.com/MRainbowM/CRM_FitOS/blob/master/ISchedule.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-schedule)> - вывести список всех записей.

## Описание класса Schedule

Класс позволяет работать с информацией о помещениях.

### Атрибуты класса Schedule

* **ID** : Bool - номер помещения в БД;
* **Trainer** : [Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer) - экземпляр класса Trainer;
* **Card** : [Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card) - экземпляр класса Trainer;
* **Service** : [Service](https://github.com/MRainbowM/CRM_FitOS/blob/master/IService.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-service) - экземпляр класса Service;
* **Room** : [Room](https://github.com/MRainbowM/CRM_FitOS/blob/master/IRoom.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-room) - экземпляр класса Room;
* **Date** : DateTime - дата занятия;
* **StartDate** : DateTime - дата начала заморозки (только для услуги заморозки карты);
* **EndDate** : DateTime - дата окончания заморозки (только для услуги заморозки карты).

[Назад](./API.md)