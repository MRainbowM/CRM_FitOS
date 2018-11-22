[Назад](./API.md)

## Описание интерфейса ITrainer

Интерфейс предназначен для работы с методами класса Trainer

### Реализация интерфейса

+ **+GetAll**() : List<[Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer)> - выводит список всех тренеров;

+ **+FindTrainerByID**(ID : int) : [Trainer](https://github.com/MRainbowM/CRM_FitOS/blob/master/ITrainer.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-trainer) - поиск тренера по ID;
    * ID -номер пользователя в БД;

+ **+Add**(FIO:string, Sex:bool,  Qualification:string, Phone:int, DOB:DateTime, Comment:string) : int - функция добавления тренера в БД;
	* FIO - ФИО тренера;
    * Sex - пол тренера;
    * Qualification - квалификация тренера;
    * Phone - номер телефона тренера;
    * DOB - дата рождения;
    * Comment - комментарий о тренере.

## Описание класса Trainer

Данный класс наследует все операции класса User, предназначен для работы с данными тренеров.

### Атрибуты класса Trainer

* **ID** : Int - номер тренера в БД;
* **FIO** : String - ФИО тренера;
* **Sex** : Bool - пол тренера;
* **Qualification** : String - квалификация тренера;
* **Phone** : Int - номер телефона тренера;
* **DOB** : DateTime - дата рождения;
* **Comment** : String - комментарий о тренере;
* **Photo** : List<Photos> - фотографии;
* **State** : bool - статус: удаленный тренер или нет.

[Назад](./API.md)