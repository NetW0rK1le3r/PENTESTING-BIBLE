#Let's assume that a song consists of some number of words. To make the dubstep remix of this song, Polycarpus inserts a certain number of words "WUB" before the first word of the song (the number may be zero), after the last word (the number may be zero), and between words (at least one between any pair of neighbouring words), and then the boy glues together all the words, including "WUB", in one string and plays the song at the club.
#For example, a song with words "I AM X" can transform into a dubstep remix as "WUBWUBIWUBAMWUBWUBX" and cannot transform into "WUBWUBIAMWUBX".
#The input consists of a single non-empty string, consisting only of uppercase English letters, the string's length doesn't exceed 200 characters
#Return the words of the initial song that Polycarpus used to make a dubsteb remix. Separate the words with a space.
#e.g. songDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB")  -->  WE ARE THE CHAMPIONS MY FRIEND.
song_decoder = lambda song : (song.replace('WUB',' ').replace('   ',' ')).replace('  ',' ').strip()
