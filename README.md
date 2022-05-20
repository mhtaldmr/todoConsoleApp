


# Todo List Console App

This project is an basic Console App example.
In the project the main theme is a Todo list with a few options.

### Used tools
- Asp.Net Console App with `.Net5.0` framework.
- No Database used in this project.
- To be able to show the Dbs, dummy datas generated in StartMenu folder.

## Insight
- In the project, just basic c# and Linq libraries has been used.
-  Examples of moving card:
```c
	if (listToMoveTodo.Where(ct => ct.Baslık == cardTitle).Count() == 1)
	{
		movedFrom = "Todo";
		TasınacakKart.Kart(listToMoveTodo, cardTitle);

		bufferCard = new Card()
		{
			Baslık = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Baslık,
			Icerik = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Icerik,
			Atanan = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Atanan,
			BüyüklükKodu = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().BüyüklükKodu
		};
```
- Parsing function
```c
    public static class TryParseIfPossible
    {
        public static byte FromStringToByte(string stringToConvert)
        {
            if (Byte.TryParse(stringToConvert, out byte byteValue))
                return byteValue;
            else
                return 0;
        }
	}
```

## Installation
- To download the project
````
	git clone https://github.com/mhtaldmr/todoConsoleApp.git
````
- To enter the file
````
	cd todoConsoleApp/
	cd ProjectTwo
````
- To run the project
````
	dotnet run
````

## Usage
- After run the project in the terminal, screen will be shown:
<img src="https://github.com/mhtaldmr/todoConsoleApp/blob/main/src/menu.PNG" alt="menu" />
- To add a new card
<img src="https://github.com/mhtaldmr/todoConsoleApp/blob/main/src/adding.PNG" alt="menu" />
- To move a card
<img src="https://github.com/mhtaldmr/todoConsoleApp/blob/main/src/moving.PNG" alt="menu" />
- To list a card
<img src="https://github.com/mhtaldmr/todoConsoleApp/blob/main/src/listing.PNG" alt="menu" />


---
