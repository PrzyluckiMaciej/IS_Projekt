Integracja systemów
Temat projektu: 
Zestawienie różnych danych statystycznych przed wybuchem pandemii COVID-19
(przed 03.2020 r.) oraz w czasie jej trwania (po 03.2020 r.), prezentacja zmian
wartości w wybranym okresie. 

Skład grupy projektowej: 
Patryk Przybyś, Maciej Przyłucki

Podział zrealizowanych zadań:
Patryk Przybyś:
- Zgromadzenie danych odnośnie zachorowań i śmierci na Covid-19
- Podział danych na te sprzed i po początku pandemii
- Eksport danych ze wszystkich tabel bazy do plików JSON, XML, YAML

Maciej Przyłucki:
- Zgromadzenie danych odnośnie wyników maturalnych
- Aplikacja serwera z wykorzystaniem REST
- Projekty interfejsów
- Implementacja ORM
- Import danych do tabel z wynikami egzaminów maturalnych
- Uwierzytelnianie i autoryzacja przy użyciu tokena JWT
- Prezentacja danych w wyniku podsumowania oraz w tabelach
- Opracowanie pliku ReadMe

Uruchamianie:
Aplikacja klienta znajduje się w folderze "Project_app", a aplikacja
serwera w folderze "Server_app". Należy najpierw uruchomić aplikację
serwera, a następnie klienta. Po uruchomieniu należy się zalogować
na konto jednego ze zdefiniowanych użtykowników:
- Admin (nazwa użytkownika: "Admin", hasło: "admin"): ma uprawnienia do
  odczytu i zapisu.
- Viewer (nazwa użytkownika: "Viewer", hasło: "viewer"): ma uprawnienia do
  odczytu. Nie może wykonać importu danych do bazy.

Opis:
Zarówno aplikacja klienta jak i serwera napisane zostały w języku C#.
Aplikacja serwera wykorzystuje ASP.NET Web API w celu komunikacji z klientem.
Aplikacja pozwala na import i eksport danych w formatach XML, JSON i YAML, wykorzystuje ORM
w celu dostępu do bazy danych, korzysta z usługi REST, używa tokenów JWT do uwierzytelniania
i autoryzacji oraz wykorzystuje poziomy izolacji w bazie danych.
Interfejs graficzny aplikacji klienta powstał z użyciem Windows Forms. 
Aplikacja pozwala na sprawdzenie licby zachorowań i śmierci w każdym dniu z podziałem
na kraje w roku 2020, a także na sprawdzenie wyników egzaminów naturalnych ze wszystkich
przedmiotów w latach 2015-2023. Tabele wyświetlające dane z bazy pozwalają na sortowanie 
rekordów względem wybranych kolumn. W zakładce "Podsumowanie" znajdują się wykresy
przedstawiające zmiany średniej liczby zachorowań i śmierci na całym świecie w danym
miesiącu oraz średniego wyniku egzaminów na dany rok.

Przykładowe pytania, na które odpowiada aplikacja:
- W jakim dniu odnotowano najwięcej zgonów na Covid-19?
- W którym kraju odnotowano pierwszy przypadek zachorowania na Covid-19?
- Czy wybuch pandemii koreluje ze zmianą średniego wyniku egzaminu maturalnego?

Przy realizacji projektu wykorzystano następujące zasoby:
a) Pakiety NuGet w aplikacji klienta:
    - MySql.Data: pakiet służący do nawiązania połączenia z bazą danych.
    - Insight.Database: pakiet służący do implementacji ORM. 
      (https://github.com/jonwagner/Insight.Database?tab=readme-ov-file)
    - Insight.Database.Providers.MySql: dodatek do pakietu Insight.Database
      pozwalający na integrację z pakietem MySql.Data.
    - RestSharp: pakiet obsługujący wysyłanie żądań przez klienta.
      (https://github.com/restsharp/RestSharp)
    - Newtonsoft.Json: pakiet do serializacji i deserializacji danych
      w formacie JSON.
    - YamlDotNet: pakiet do serializacji i deserializacji danych
      w formacie YAML.
    - WinForms.DataVisualization: pakiet służący do wizualizacji danych.
      W projekcie wykorzystany został do utworzenia i stylizowania wykresów.
b) Pakiety NuGet w aplikacji serwera:
    - MySql.Data
    - Insight.Database
    - Insight.Database.Providers.MySql
    - Microsoft.AspNetCore.Authentication.JwtBearer i System.IdentityModel.Tokens.Jwt:
      pakiety służące do generowania i autoryzacji tokenów JWT.
c) Inne:
    - SortableBindingList: klasa listy, która umożliwia sortowanie danych
      umieszczonych w obiekcie typu DataGridView, który prezentuje dane
      w postaci tabeli.
      (https://martinwilley.com/net/code/forms/sortablebindinglist.html)

Źródła danych:
- Wyniki egzaminów maturalnych: https://dane.gov.pl/pl/dataset/2621,srednie-wyniki-egzaminu-maturalnego
