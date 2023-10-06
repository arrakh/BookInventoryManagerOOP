## I got bored so i told Chat GPT to generate me an OOP problem
Here's what it generates:

**Problem: Bookstore Inventory System**

*Context:*
You're tasked with designing a system to manage the inventory for a bookstore. The store holds a variety of books and employs several staff members, each with their own roles.

*Requirements:*
```
Entities:
Book:
Properties: Title, Author, Price, Genre.

Employee:
Properties: Name, Role.

Genre:
Types: Fiction, Non-Fiction, Children, Sci-Fi, History.
```

Relationships between entities (Rules):
```
Every book belongs to exactly one genre.
Every employee can be responsible for one or more genres (i.e., they handle the inventory for those genres).
An employee can have the role of either Sales, InventoryManager, or Cashier.
Only employees with the InventoryManager role can be responsible for a genre.
```

More constraints:
```
Have at least 3 genres.
Have at least 2 employees with the role InventoryManager.
Each InventoryManager is responsible for at least 1 genre.
```

Statistical data:
```
Print the number of books under each genre.
Print each employee and the genres they're responsible for.
Print the total value of books under each InventoryManager (based on book prices).
```

## Sample Output
````
===================
Book Count by Genres:
- Children: 21
- Fiction: 20
- History: 23
- NonFiction: 17
- SciFi: 19
===================
Employee List (10):
- Frank Martinez: Sales
- Bob Schmidt: Cashier
- Frank Sanchez: InventoryManager
    > Responsible Genres: Fiction, NonFiction, SciFi
- Bob Nguyen: Sales
- Eve Martinez: InventoryManager
    > Responsible Genres: History
- Charlie Smith: Sales
- Eve Rodriguez: InventoryManager
    > Responsible Genres: Fiction, NonFiction, SciFi
- Alice Martinez: InventoryManager
    > Responsible Genres: Fiction, History, SciFi
- Diana Patel: InventoryManager
    > Responsible Genres: Fiction
- Alice Nguyen: Sales
===================
Inventory Manager Total Values:
- Frank Sanchez:
Total Book Value: $6401
    > [Fiction] Some Rusty Tree, by Eve Patel ($194)
    > [Fiction] A Silent Book, by Harry Garcia ($198)
    > [Fiction] An Bright Hat, by Eve Sanchez ($25)
    > [Fiction] An Bright Tree, by Bob Novak ($192)
    > [Fiction] A Tall Ball, by Jack Wang ($87)
    > [Fiction] One Big Hat, by Alice Johnson ($167)
    > [Fiction] His Big Rocket, by Eve Novak ($102)
    > [Fiction] One Bright Tree, by Alice Murphy ($21)
    > [Fiction] His Red Ball, by Grace Wang ($64)
    > [Fiction] This Fast Book, by Charlie Murphy ($72)
    > [Fiction] An Red Rocket, by Harry Khan ($141)
    > [Fiction] His Rusty Bike, by Eve Singh ($155)
    > [Fiction] One Small Car, by Grace Nguyen ($25)
    > [Fiction] This Rusty Tree, by Eve Singh ($191)
    > [Fiction] A Big Rocket, by Grace Perez ($112)
    > [Fiction] Her Bright Book, by Harry Kim ($24)
    > [Fiction] A Bright Tree, by Ivy Johnson ($147)
    > [Fiction] The Silent Tree, by Charlie Brown ($181)
    > [Fiction] Her Fast Rocket, by Harry Novak ($97)
    > [Fiction] An Silent Tree, by Eve Khan ($196)
    > [NonFiction] His Mighty Hat, by Harry Wang ($55)
    > [NonFiction] The Big Bike, by Ivy Rodriguez ($83)
    > [NonFiction] The Tall Car, by Charlie Garcia ($85)
    > [NonFiction] This Mighty Book, by Charlie Smith ($136)
    > [NonFiction] An Dark Shoe, by Jack Johnson ($56)
    > [NonFiction] One Big Shoe, by Alice Kim ($190)
    > [NonFiction] This Mighty Ball, by Frank Johnson ($77)
    > [NonFiction] Her Red Shoe, by Grace Rodriguez ($126)
    > [NonFiction] One Small Rocket, by Alice Rodriguez ($68)
    > [NonFiction] A Mighty Tree, by Jack Brown ($78)
    > [NonFiction] One Dark Car, by Jack Murphy ($187)
    > [NonFiction] This Mighty Hat, by Eve Jones ($128)
    > [NonFiction] Some Big Book, by Frank Murphy ($198)
    > [NonFiction] A Red Ball, by Bob Sanchez ($165)
    > [NonFiction] Her Mighty Shoe, by Charlie Murphy ($40)
    > [NonFiction] This Big Guitar, by Ivy Nguyen ($97)
    > [NonFiction] One Tall Guitar, by Frank Murphy ($74)
    > [SciFi] My Tall Car, by Jack Nguyen ($189)
    > [SciFi] The Tall Kite, by Ivy Jones ($129)
    > [SciFi] Her Red Bike, by Alice Rodriguez ($160)
    > [SciFi] A Bright Book, by Bob Jones ($128)
    > [SciFi] One Bright Bike, by Bob Brown ($89)
    > [SciFi] His Rusty Tree, by Eve Singh ($25)
    > [SciFi] My Big Guitar, by Bob Sanchez ($179)
    > [SciFi] That Tall Hat, by Grace Murphy ($127)
    > [SciFi] One Red Bike, by Eve Silva ($95)
    > [SciFi] My Silent Bike, by Diana Lee ($125)
    > [SciFi] Her Big Hat, by Charlie Silva ($65)
    > [SciFi] The Fast Guitar, by Ivy Silva ($126)
    > [SciFi] One Rusty Rocket, by Grace Murphy ($140)
    > [SciFi] A Mighty Shoe, by Harry Sanchez ($163)
    > [SciFi] One Bright Hat, by Jack Novak ($132)
    > [SciFi] His Bright Book, by Grace Murphy ($96)
    > [SciFi] A Rusty Shoe, by Frank Murphy ($32)
    > [SciFi] This Mighty Rocket, by Jack Kim ($61)
    > [SciFi] That Red Shoe, by Diana Martinez ($106)

- Eve Martinez:
Total Book Value: $2467
    > [History] A Mighty Ball, by Harry Schmidt ($109)
    > [History] His Small Bike, by Alice Smith ($91)
    > [History] This Fast Car, by Ivy Novak ($172)
    > [History] Her Silent Shoe, by Charlie Schmidt ($61)
    > [History] This Silent Shoe, by Harry Sanchez ($97)
    > [History] An Fast Shoe, by Grace Wang ($114)
    > [History] Some Rusty Book, by Grace Rodriguez ($95)
    > [History] That Tall Ball, by Diana Patel ($143)
    > [History] This Bright Shoe, by Bob Rodriguez ($109)
    > [History] One Silent Kite, by Eve Jones ($135)
    > [History] My Big Book, by Frank Jones ($99)
    > [History] A Dark Guitar, by Harry Silva ($78)
    > [History] An Tall Kite, by Eve Nguyen ($43)
    > [History] Some Tall Rocket, by Grace Nguyen ($55)
    > [History] An Rusty Guitar, by Charlie Rodriguez ($50)
    > [History] An Rusty Guitar, by Ivy Jones ($154)
    > [History] This Red Car, by Alice Brown ($88)
    > [History] This Mighty Hat, by Charlie Sanchez ($20)
    > [History] The Bright Guitar, by Grace Perez ($28)
    > [History] One Rusty Car, by Bob Silva ($186)
    > [History] The Fast Car, by Ivy Smith ($179)
    > [History] One Big Car, by Jack Martinez ($195)
    > [History] An Bright Ball, by Frank Rodriguez ($166)

- Eve Rodriguez:
Total Book Value: $6401
    > [Fiction] Some Rusty Tree, by Eve Patel ($194)
    > [Fiction] A Silent Book, by Harry Garcia ($198)
    > [Fiction] An Bright Hat, by Eve Sanchez ($25)
    > [Fiction] An Bright Tree, by Bob Novak ($192)
    > [Fiction] A Tall Ball, by Jack Wang ($87)
    > [Fiction] One Big Hat, by Alice Johnson ($167)
    > [Fiction] His Big Rocket, by Eve Novak ($102)
    > [Fiction] One Bright Tree, by Alice Murphy ($21)
    > [Fiction] His Red Ball, by Grace Wang ($64)
    > [Fiction] This Fast Book, by Charlie Murphy ($72)
    > [Fiction] An Red Rocket, by Harry Khan ($141)
    > [Fiction] His Rusty Bike, by Eve Singh ($155)
    > [Fiction] One Small Car, by Grace Nguyen ($25)
    > [Fiction] This Rusty Tree, by Eve Singh ($191)
    > [Fiction] A Big Rocket, by Grace Perez ($112)
    > [Fiction] Her Bright Book, by Harry Kim ($24)
    > [Fiction] A Bright Tree, by Ivy Johnson ($147)
    > [Fiction] The Silent Tree, by Charlie Brown ($181)
    > [Fiction] Her Fast Rocket, by Harry Novak ($97)
    > [Fiction] An Silent Tree, by Eve Khan ($196)
    > [NonFiction] His Mighty Hat, by Harry Wang ($55)
    > [NonFiction] The Big Bike, by Ivy Rodriguez ($83)
    > [NonFiction] The Tall Car, by Charlie Garcia ($85)
    > [NonFiction] This Mighty Book, by Charlie Smith ($136)
    > [NonFiction] An Dark Shoe, by Jack Johnson ($56)
    > [NonFiction] One Big Shoe, by Alice Kim ($190)
    > [NonFiction] This Mighty Ball, by Frank Johnson ($77)
    > [NonFiction] Her Red Shoe, by Grace Rodriguez ($126)
    > [NonFiction] One Small Rocket, by Alice Rodriguez ($68)
    > [NonFiction] A Mighty Tree, by Jack Brown ($78)
    > [NonFiction] One Dark Car, by Jack Murphy ($187)
    > [NonFiction] This Mighty Hat, by Eve Jones ($128)
    > [NonFiction] Some Big Book, by Frank Murphy ($198)
    > [NonFiction] A Red Ball, by Bob Sanchez ($165)
    > [NonFiction] Her Mighty Shoe, by Charlie Murphy ($40)
    > [NonFiction] This Big Guitar, by Ivy Nguyen ($97)
    > [NonFiction] One Tall Guitar, by Frank Murphy ($74)
    > [SciFi] My Tall Car, by Jack Nguyen ($189)
    > [SciFi] The Tall Kite, by Ivy Jones ($129)
    > [SciFi] Her Red Bike, by Alice Rodriguez ($160)
    > [SciFi] A Bright Book, by Bob Jones ($128)
    > [SciFi] One Bright Bike, by Bob Brown ($89)
    > [SciFi] His Rusty Tree, by Eve Singh ($25)
    > [SciFi] My Big Guitar, by Bob Sanchez ($179)
    > [SciFi] That Tall Hat, by Grace Murphy ($127)
    > [SciFi] One Red Bike, by Eve Silva ($95)
    > [SciFi] My Silent Bike, by Diana Lee ($125)
    > [SciFi] Her Big Hat, by Charlie Silva ($65)
    > [SciFi] The Fast Guitar, by Ivy Silva ($126)
    > [SciFi] One Rusty Rocket, by Grace Murphy ($140)
    > [SciFi] A Mighty Shoe, by Harry Sanchez ($163)
    > [SciFi] One Bright Hat, by Jack Novak ($132)
    > [SciFi] His Bright Book, by Grace Murphy ($96)
    > [SciFi] A Rusty Shoe, by Frank Murphy ($32)
    > [SciFi] This Mighty Rocket, by Jack Kim ($61)
    > [SciFi] That Red Shoe, by Diana Martinez ($106)

- Alice Martinez:
Total Book Value: $7025
    > [Fiction] Some Rusty Tree, by Eve Patel ($194)
    > [Fiction] A Silent Book, by Harry Garcia ($198)
    > [Fiction] An Bright Hat, by Eve Sanchez ($25)
    > [Fiction] An Bright Tree, by Bob Novak ($192)
    > [Fiction] A Tall Ball, by Jack Wang ($87)
    > [Fiction] One Big Hat, by Alice Johnson ($167)
    > [Fiction] His Big Rocket, by Eve Novak ($102)
    > [Fiction] One Bright Tree, by Alice Murphy ($21)
    > [Fiction] His Red Ball, by Grace Wang ($64)
    > [Fiction] This Fast Book, by Charlie Murphy ($72)
    > [Fiction] An Red Rocket, by Harry Khan ($141)
    > [Fiction] His Rusty Bike, by Eve Singh ($155)
    > [Fiction] One Small Car, by Grace Nguyen ($25)
    > [Fiction] This Rusty Tree, by Eve Singh ($191)
    > [Fiction] A Big Rocket, by Grace Perez ($112)
    > [Fiction] Her Bright Book, by Harry Kim ($24)
    > [Fiction] A Bright Tree, by Ivy Johnson ($147)
    > [Fiction] The Silent Tree, by Charlie Brown ($181)
    > [Fiction] Her Fast Rocket, by Harry Novak ($97)
    > [Fiction] An Silent Tree, by Eve Khan ($196)
    > [History] A Mighty Ball, by Harry Schmidt ($109)
    > [History] His Small Bike, by Alice Smith ($91)
    > [History] This Fast Car, by Ivy Novak ($172)
    > [History] Her Silent Shoe, by Charlie Schmidt ($61)
    > [History] This Silent Shoe, by Harry Sanchez ($97)
    > [History] An Fast Shoe, by Grace Wang ($114)
    > [History] Some Rusty Book, by Grace Rodriguez ($95)
    > [History] That Tall Ball, by Diana Patel ($143)
    > [History] This Bright Shoe, by Bob Rodriguez ($109)
    > [History] One Silent Kite, by Eve Jones ($135)
    > [History] My Big Book, by Frank Jones ($99)
    > [History] A Dark Guitar, by Harry Silva ($78)
    > [History] An Tall Kite, by Eve Nguyen ($43)
    > [History] Some Tall Rocket, by Grace Nguyen ($55)
    > [History] An Rusty Guitar, by Charlie Rodriguez ($50)
    > [History] An Rusty Guitar, by Ivy Jones ($154)
    > [History] This Red Car, by Alice Brown ($88)
    > [History] This Mighty Hat, by Charlie Sanchez ($20)
    > [History] The Bright Guitar, by Grace Perez ($28)
    > [History] One Rusty Car, by Bob Silva ($186)
    > [History] The Fast Car, by Ivy Smith ($179)
    > [History] One Big Car, by Jack Martinez ($195)
    > [History] An Bright Ball, by Frank Rodriguez ($166)
    > [SciFi] My Tall Car, by Jack Nguyen ($189)
    > [SciFi] The Tall Kite, by Ivy Jones ($129)
    > [SciFi] Her Red Bike, by Alice Rodriguez ($160)
    > [SciFi] A Bright Book, by Bob Jones ($128)
    > [SciFi] One Bright Bike, by Bob Brown ($89)
    > [SciFi] His Rusty Tree, by Eve Singh ($25)
    > [SciFi] My Big Guitar, by Bob Sanchez ($179)
    > [SciFi] That Tall Hat, by Grace Murphy ($127)
    > [SciFi] One Red Bike, by Eve Silva ($95)
    > [SciFi] My Silent Bike, by Diana Lee ($125)
    > [SciFi] Her Big Hat, by Charlie Silva ($65)
    > [SciFi] The Fast Guitar, by Ivy Silva ($126)
    > [SciFi] One Rusty Rocket, by Grace Murphy ($140)
    > [SciFi] A Mighty Shoe, by Harry Sanchez ($163)
    > [SciFi] One Bright Hat, by Jack Novak ($132)
    > [SciFi] His Bright Book, by Grace Murphy ($96)
    > [SciFi] A Rusty Shoe, by Frank Murphy ($32)
    > [SciFi] This Mighty Rocket, by Jack Kim ($61)
    > [SciFi] That Red Shoe, by Diana Martinez ($106)

- Diana Patel:
Total Book Value: $2391
    > [Fiction] Some Rusty Tree, by Eve Patel ($194)
    > [Fiction] A Silent Book, by Harry Garcia ($198)
    > [Fiction] An Bright Hat, by Eve Sanchez ($25)
    > [Fiction] An Bright Tree, by Bob Novak ($192)
    > [Fiction] A Tall Ball, by Jack Wang ($87)
    > [Fiction] One Big Hat, by Alice Johnson ($167)
    > [Fiction] His Big Rocket, by Eve Novak ($102)
    > [Fiction] One Bright Tree, by Alice Murphy ($21)
    > [Fiction] His Red Ball, by Grace Wang ($64)
    > [Fiction] This Fast Book, by Charlie Murphy ($72)
    > [Fiction] An Red Rocket, by Harry Khan ($141)
    > [Fiction] His Rusty Bike, by Eve Singh ($155)
    > [Fiction] One Small Car, by Grace Nguyen ($25)
    > [Fiction] This Rusty Tree, by Eve Singh ($191)
    > [Fiction] A Big Rocket, by Grace Perez ($112)
    > [Fiction] Her Bright Book, by Harry Kim ($24)
    > [Fiction] A Bright Tree, by Ivy Johnson ($147)
    > [Fiction] The Silent Tree, by Charlie Brown ($181)
    > [Fiction] Her Fast Rocket, by Harry Novak ($97)
    > [Fiction] An Silent Tree, by Eve Khan ($196)
````
