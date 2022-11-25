
# SeterraMapChooser
Chooses Seterra maps and categories using an algorithm AstroTheLast created.

## Map Selection

Maps will be selected through an algorithm which will select the quizzes randomly. However, there are some guidelines that the algorithm will follow to select the quizzes.

Of the 14 quizzes,

3 will be 6-15 elements
4 will be 16-30 elements
4 will be 31-45 elements
3 will be 46-70 elements

## Category Selection

Each map will be given a random game mode type from the following list: 

- Pin
- Pin Hard
- Place Labels
- Multiple Choice
- Shownext

However, there will not be more than one specific game mode present for each element category. What that means is, if there is already a 6-15 element Place Labels map, the algorithm will not assign the Place Labels category to another 6-15 element map. This is just to ensure that there isn't a full round dominated by one category, as there should be a variety. Along with this, some categories are more likely to appear than others. the percentage chance of a category being chosen for a map is detailed below.

- Pin: 25%
- Pin Hard: 15%
- Place Labels: 25%
- Multiple Choice: 20%
- Shownext: 15%

This is what an example map selection would look like:

![](https://cdn.discordapp.com/attachments/833118228800733217/1045686912897261618/mapselection.png)


