# Moment-4-API
API skapat med hjäp av ASP.net Core. Detta API innehåller stöd för CRUD i ThunderClient. 

Består av två tabeller, en för låtar och en för album. 

Exempel på stt lägga till Album:
```
{
"Title":"Yellow Submarine",
"Year":"1969"
}
```

Exempel på att lägga till låt: 
```
{
  "Artist": "The Beatles",
  "Title":"Nowhere Man ",
  "Length": 164,
  "Category": "Rock",
  "AlbumId": 3
}
```

Låt kopplas till album med hjälp av att ett albums ID skickas med. 
Utskriften för låtar blir följande: 
```
  {
    "id": 14,
    "artist": "The Beatles",
    "title": "Nowhere Man ",
    "length": 164,
    "category": "Rock",
    "albumId": 3,
    "album": {
      "id": 3,
      "title": "Yellow Submarine",
      "year": 1969
    }
  }
  ```

