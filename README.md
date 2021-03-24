Console Application<br>
Exercises: Sets and Dictionaries Advanced
# TheVLogger
Create a program that keeps information about __vloggers__ and their __followers__. The __input__ will come as a sequence of strings, where each string will represent a __valid__ command. The commands will be presented in the following format:
- "__{vloggername}" joined The V-Logger__ – keep the vlogger in your records.
  - Vloggernames __consist of only one word__.
  - If the __given vloggername__ already __exists__, __ignore__ that command.

- "__{vloggername} followed {vloggername}__" – The first vlogger followed the second vlogger.
  - If __any__ of the __given vlogernames does not exist__ in you collection, __ignore__ that command.
  - Vlogger __cannot__ follow __himself__
  - Vlogger __cannot__ follow someone he is __already a follower of__

- "__Statistics__" - Upon receiving this command, you have to print a statistic about the vloggers.
 
Each vlogger has an unique __vloggername__. __Vloggers__ can __follow other vloggers__ and a vlogger __can follow as many other vloggers as he wants__, but he __cannot__ follow __himself__ or follow someone he is __already a follower of__. You need to print the __total count__ of __vloggers__ in your collection. Then you have to print __the most popular__ vlogger – the one with the most followers, with __his followers__. If more than one vloggers have the __same number__ of __followers__, print the one __following less__ people and his __followers__ should be printed in __lexicographical order__ (in case the vlogger has __no followers__, print just the first line, which is described __below__). Lastly, print __the rest vloggers__, ordered by the __count__ of followers in __descending__ order, then by the number of vloggers he follows in __ascending__ order. The whole __output must be__ in the following format:

"__The V-Logger has a total of {registered vloggers} vloggers in its logs.__<br>
__1. {mostFamousVlogger} : {followers} followers, {followings} following__<br>
__*  {follower1}__<br>
__*  {follower2} … __<br>
__{No}. {vlogger} : {followers} followers, {followings} following__<br>
__{No}. {vlogger} : {followers} followers, {followings} following …__"
## Input
- The input will come in the format described above.
## Output
- On the first line, print __the total count of vloggers__ in the format described above.
- On the second line, print __the most popular__ vlogger in the format described above.
- On the __next__ lines, print all of __the rest__ vloggers in the format described above.
## Constraints
- There will be __no invalid__ input.
- There will be no situation where __two vloggers__ have __equal__ count of __followers__ and __equal__ count of __followings__
- Allowed time/memory: __100ms/16MB__.
## Examples
Input|Output
-----|-----
EmilConrad joined The V-Logger<br>VenomTheDoctor joined The V-Logger<br>Saffrona joined The V-Logger<br>Saffrona followed EmilConrad<br>Saffrona followed VenomTheDoctor<br>EmilConrad followed VenomTheDoctor<br>VenomTheDoctor followed VenomTheDoctor<br>Saffrona followed EmilConrad<br>Statistics|The V-Logger has a total of 3 vloggers in its logs.<br>1. VenomTheDoctor : 2 followers, 0 following<br>*  EmilConrad<br>*  Saffrona<br>2. EmilConrad : 1 followers, 1 following<br>3. Saffrona : 0 followers, 2 following
JennaMarbles joined The V-Logger<br>JennaMarbles followed Zoella<br>AmazingPhil joined The V-Logger<br>JennaMarbles followed AmazingPhil<br>Zoella joined The V-Logger<br>JennaMarbles followed Zoella<br>Zoella followed AmazingPhil<br>Christy followed Zoella<br>Zoella followed Christy<br>JacksGap joined The V-Logger<br>JacksGap followed JennaMarbles<br>PewDiePie joined The V-Logger<br>Zoella joined The V-Logger<br>Statistics|The V-Logger has a total of 5 vloggers in its logs.<br>1. AmazingPhil : 2 followers, 0 following<br>*  JennaMarbles<br>*  Zoella<br>2. Zoella : 1 followers, 1 following<br>3. JennaMarbles : 1 followers, 2 following<br>4. PewDiePie : 0 followers, 0 following<br>5. JacksGap : 0 followers, 1 following
