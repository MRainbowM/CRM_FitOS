[Назад](./API.md)

## Описание интерфейса IPayment

Интерфейс предназначен для работы с методами класса Payment

### Реализация интерфейса

+ **+Add**(IDClient:int, Date:DateTime, Amount:int) : int - Добавить платеж;
	* IDClient - номер карты в БД;
	* Date - дата платежа;
	* Amount - сумма;

+ **+Del**(ID : int) : bool – функция удаления платежа из БД;
	* ID - номер платежа в БД;

+ **+GetAll**() : List<[Payment](https://github.com/MRainbowM/CRM_FitOS/blob/master/IPayment.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-payment)> - вывести список всех платежей.

## Описание класса Payment

Класс позволяет работать с платежами. 

### Атрибуты класса Payment

* **ID** : Int - номер платежа в БД;
* **Card** : [Card](https://github.com/MRainbowM/CRM_FitOS/blob/master/ICard.md#%D0%BE%D0%BF%D0%B8%D1%81%D0%B0%D0%BD%D0%B8%D0%B5-%D0%BA%D0%BB%D0%B0%D1%81%D1%81%D0%B0-card) - клубная карта клиента;
* **Client** : [Client](https://github.com/MRainbowM/CRM_FitOS/blob/master/IClient.md) - клиент, который совершил платеж;
* **Date** : DateTime - дата платежа;
* **Amount** : Float - сумма платежа.

[Назад](./API.md)
