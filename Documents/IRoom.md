[Назад](./API.md)

## Описание интерфейса IRoom

Интерфейс предназначен для работы с методами класса Room

### Реализация интерфейса

+ **+Add**(Name:string, Equipment:string, Capacity:int,Comment:string) - Добавить помещение;
	* Name - название помещения;
	* Equipment - оборудование помещения;
	* Capacity - вместимость помещения;
	* Comment - комментарий о помещении;
+ **+Del**(ID : int) – функция удаления помещение (Присвоение статуса «удаленное»);
	* ID - номер помещения в БД;

+ **+Save**(Name:string, Equipment:string, Capasity:int,Comment:string) – функция сохранения изменений;
	* Name - название помещения;
	* Equipment - оборудование помещения;
	* Capacity - вместимость помещения;
	* Comment - комментарий о помещении;

+ **+GetAll**() - вывести список всех помещений;

+ **+FindRoomByID**(ID : int) - поискпо ID;
	* ID - номер помещения в БД;

+ **+GetScheduleRoomByTime**(ID:int) - показать расписание помещения;
	* ID - номер помещения в БД.

## Описание класса Room

Класс позволяет работать с информацией о помещениях.

### Атрибуты класса Room

* **ID** : Bool - номер помещения в БД;
* **Name** : String - название помещения;
* **Equipment** : String - оборудование помещения;
* **Capacity** : Int - вместимость помещения;
* **Comment** : String - комментарий о помещении;
* **State** : Bool - статус помещения: удаленное или нет;
* **Photo** : List<[Photo](https://github.com/MRainbowM/CRM_FitOS/blob/master/IPhoto.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-photo)> - фотографии помещения.

[Назад](./API.md)