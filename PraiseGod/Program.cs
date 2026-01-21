using System;

    namespace Great
    {
        class Job
        {
            static void Main(string[] args)
            {

                {
            Console.WriteLine("Choose a quiz:");
            Console.WriteLine("a) Genesis 1-10 Quiz");
            Console.WriteLine("b) Genesis 10-20 Quiz");
            Console.WriteLine("c) Genesis 20-30 Quiz");
            Console.WriteLine("d) Matthew 1-10 Quiz");

            string input = Console.ReadLine(); // safer than ReadKey
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No input provided.");
                return;
            }

            char choice = input[0]; // take first character


            switch (choice)
            {
                case 'a':
                    Genesis1to10quiz();
                    break;
                case 'b':
                    Genesis10to20quiz();
                    break;
                case 'c':
                    Genesis20to30quiz();
                    break;
                case 'd':
                    Matthew1to10quiz();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a, b, c or d");
                    break;
            }
        }



                 static void Genesis1to10quiz()
        {


    Console.WriteLine("What was the first thing God said in Genesis?");
    string answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Let there be light");

    Console.WriteLine("What did God make the two great lights for?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("One to rule the day and one to rule the night");

    Console.WriteLine("What did God call the dry land?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Earth");

    Console.WriteLine("What was the name of the first man?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Adam");

    Console.WriteLine("What was the name of the first woman?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Eve");

    Console.WriteLine("What was the name of Adam and Eve's two first children?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Cain and Abel");

    Console.WriteLine("When did God rest from doing his work?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("On the seventh day");

    Console.WriteLine("In Genesis 2, what did God do to the 7th day?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He blessed it and sanctified it");

    Console.WriteLine("What was man formed from in Genesis 2?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The dust of the ground");

    Console.WriteLine("After God formed man from dust, what did he do to give him life?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He breathed into his nostrils the breath of life");

    Console.WriteLine("Where did God plant the Garden in Eden?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Eastward");

    Console.WriteLine("Where did God put man when he formed him?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Eastward, in the Garden of Eden?");

    Console.WriteLine("What two trees did God put in the midst of the Garden?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The tree of life and the tree of good and evil");

    Console.WriteLine("What was the name of the first river in Genesis 2?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Pison");

    Console.WriteLine("What does this river compass?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Havilah");

        Console.WriteLine("What minerals are in Havilah?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Gold, bdellium and the onyx stone");

        Console.WriteLine("What is the name of the second river?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Gihon");

        Console.WriteLine("What country does Gihon compass?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Ethiopia");

        Console.WriteLine("What is the name of the third river?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Hiddekel");

        Console.WriteLine("Where is it?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("It goes towards the east of Assyria");

        Console.WriteLine("What is the fourth river?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Euphrates");

        Console.WriteLine("What tree was Adam and Eve forbidden to eat from?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The Tree Of Good and Evil");

        Console.WriteLine("How were the beasts of the field and fowls of the air named?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("God brought them to Adam to see what he would name them, and so they were named");

        Console.WriteLine("How was Eve created?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("God did not want man to be alone, he wanted him to have a helper, so he caused Adam to fall into a deep sleep, then he made Eve from one of Adam's ribs, then she was brought to Adam");

        Console.WriteLine("What did Adam say when Eve was created?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("This is now bone of my bones, and flesh of my flesh; she shall be called Woman, because she was taken out of Man");

    Console.WriteLine("What does Genesis say a man should do after gaining a wife?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He shall leave his father and mother, and shall cleave unto his wife: and they shall be one flesh");

    Console.WriteLine("Genesis chapter 2 states they were both naked but they were not _______");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("ashamed");

    Console.WriteLine("Which brother between Cain and Abel was mentioned first?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Cain");

    Console.WriteLine("Which brother between Cain and Abel was mentioned second?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Abel");

    Console.WriteLine("What was Abel a keeper of?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("sheep");

    Console.WriteLine("What was Cain a tiller of");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("the ground");

    Console.WriteLine("What did Cain bring as an offering to the Lord?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Fruit of the ground");

    Console.WriteLine("What did Abel bring as an offering to the Lord?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The firstlings of his flock and of the fat thereof");

    Console.WriteLine("What was the Lord's reaction to Cain and Abel's offerings?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He had respect for Abel's offerings but not Cain's");

    Console.WriteLine("How did Abel die?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Cain slew him because he was jealous that the Lord approved Abel's offering and not his");

    Console.WriteLine("What was the result of Cain killing Abel?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The Lord punished him, Cain was banished and received his mark");

    Console.WriteLine("Where did Cain dwell after he was banished from the presence of the Lord?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He resided east of Eden in the land of Nod");

    Console.WriteLine("What was the name of Cain's first son?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Enoch");

    Console.WriteLine("What did Cain name the city he built?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He named it after Enoch, his son");

    Console.WriteLine("Who were the descendents of Enoch?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Enoch begat Irad, Irad begat Mehujael, Mehujael begat Methusael, Methusael begat Lamech");

    Console.WriteLine("What was Adam's third son called?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Seth");

    Console.WriteLine("What was Seth's son called?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Enos");

    Console.WriteLine("What was the human race called in Genesis 5?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Adam");

    Console.WriteLine("How long did Adam live before he begat Seth?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("130 years");

    Console.WriteLine("How long did Adam live after he begat Seth?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("800 years");

    Console.WriteLine("How long did Seth live?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("912 years in total");

    Console.WriteLine("How many years did Adam live in total?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("930 years");

    Console.WriteLine("How does the Bible describe Noah in Genesis 6?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("As a just and perfect man in his generations");

    Console.WriteLine("What did God instruct Noah to do?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Build an Ark");

    Console.WriteLine("What did God do to the earth in Genesis 6?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He sent a flood and destroyed it");

    Console.WriteLine("Who found grace in the eyes of the Lord?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Noah");

    Console.WriteLine("What was Noah's description in Genesis 6?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was described as a just man and perfect in his generations");

    Console.WriteLine("What were the names of Noah's sons as listed in Genesis 6?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Shem, Ham and Japheth");

    Console.WriteLine("What was said about Earth in Genesis 6:11?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The Earth was corrupt and filled with violence");

    Console.WriteLine("What were the dimensions of the Ark?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("It was three hundred cubits in length, the breadth was fifty cubits and the height is thirty cubits");

    Console.WriteLine("How many stories did the Ark have?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Three stories");

    Console.WriteLine("God said in Genesis 7:4 'for yet ____ days' ");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("seven");

    Console.WriteLine("In Genesis 7, how many days did God cause it to rain for?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("forty days and forty nights");

    Console.WriteLine("How old was Noah when the flood came?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Six hundred years old");

    Console.WriteLine("In Genesis 7, how long did the water prevail upon the earth?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("One hundred and fifty days");

    Console.WriteLine("Which month and day did the ark rest?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The seventh month on the seventeenth day");

    Console.WriteLine("Where did the ark rest after the flood?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The mountains of Ararat");

    Console.WriteLine("When were the top of the mountains seen?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("On the first day of the tenth month");

    Console.WriteLine("In Genesis 8:6, how long was it until Noah opened the window of the ark?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Forty days");

    Console.WriteLine("What did the dove bring back to Noah that signified the flood waters had dissipated?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("She had an olive leaf in her mouth");

    Console.WriteLine("In Genesis 8, did Noah make burnt offerings to God?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes he did, he built an altar to do so");

    Console.WriteLine("What was God’s promise after the flood?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He said he will not curse the ground any more for man's sake");

    Console.WriteLine("What was the first thing God said to Noah and his sons in Genesis 9?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Be fruitful, and multiply, and replenish the earth ");

    Console.WriteLine("Did God say every beast shall fear man in Genesis 9?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes");

    Console.WriteLine("In Genesis 9, what shall be meat for man?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Every moving thing");

    Console.WriteLine("In Genesis 9, what shouldn’t a man eat?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Flesh with blood in it");

    Console.WriteLine("What does Genesis 9:6 say?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Whoso sheddeth man’s blood, by man also shall his blood be shed ");

    Console.WriteLine("What was God’s promise in Genesis 9:11");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("And I will establish my covenant with you; neither shall all flesh be cut off any more by the waters of a flood; neither shall there be any more a flood to destroy the earth ");

    Console.WriteLine("What was the rainbow a symbol of in Genesis 9?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("A token of God’s covenant with man not to destroy the earth by a flood");

    Console.WriteLine("What did God say would happen when he brings a cloud over the earth?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("A rainbow shall be seen");

    Console.WriteLine("How old did Noah live after the flood?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("350 years");

    Console.WriteLine("How old was Noah when he died?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("950 years old");

    Console.WriteLine("What was Nimrod's reputation?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was a mighty hunter before the Lord");

            }

             static void Genesis10to20quiz()
        {

    Console.WriteLine("In Genesis 11:1, how many languages did people in the earth speak?");
    string answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Everyone spoke one language");

    Console.WriteLine("In Genesis 11, why did God cause there to be several languages?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Because human beings built a tower to reach the heavens");

    Console.WriteLine("What was this tower called?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("It was called Babel");

    Console.WriteLine("In Genesis 11:9, what else did God do as a consequence of this?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He scattered them across the face of the earth");

    Console.WriteLine("In Genesis 12:1, what was God’s command to Abram?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("To leave his nation");

    Console.WriteLine("What did God say he would do for Abram in Genesis 12:2?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("And I will make of thee a great nation, and I will bless thee, and make thy name great; and thou shalt be a blessing");

    Console.WriteLine("What did Abram do in Genesis 12:4?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("So Abram departed, as the Lord had spoken unto him; and Lot went with him: and Abram was seventy and five years old when he departed out of Haran");

    Console.WriteLine("What land did Abram go into in Genesis 12:5?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Canaan");

    Console.WriteLine("What did Abram do in Genesis 12:7?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He built an altar for the Lord");

    Console.WriteLine("In Genesis 12, what did Abram ask Sarai to tell Pharoah?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("That she was his sister");

    Console.WriteLine("In Genesis 12, why did God punish Pharoah with plagues?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Because he took Sarai in his house");

    Console.WriteLine("In Genesis 13, why did Lot and Abram separate?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("There was a strife between Abram’s herdsmen and Lot’s herdsmen");

    Console.WriteLine("What did Abram say in response to this strife?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("And Abram said unto Lot, Let there be no strife, I pray thee, between me and thee, and between my herdmen and thy herdmen; for we be brethren. After this, they separated ");

    Console.WriteLine("Where did Lot go after the strife?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He went to the plain of Jordan ");

    Console.WriteLine("Where did Abram go after the strife?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("To the land of Canaan");

    Console.WriteLine("What was the reputation of the men of Sodom?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("They were sinners and exceedingly wicked ");

    Console.WriteLine("At the end of Genesis 13, where did Abram move?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He went to the plain of Mamre, which is in Hebron");

    Console.WriteLine("What did he do after he got to Mamre?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He built an altar for the Lord ");

    Console.WriteLine("What happened to Lot in Genesis 14?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was taken captive");

    Console.WriteLine("What was Melchizedek king of?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Salem");

    Console.WriteLine("As Sarai didn’t give Abram a heir, what was her suggestion?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("For him to lay with Hagar");

    Console.WriteLine("What nation was Hagar from?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Egypt");

    Console.WriteLine("Did Abram marry Hagar?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes he did");

    Console.WriteLine("What was Sarai’s reaction to Hagar becoming pregnant");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("She was despised in Sarai’s eyes");

    Console.WriteLine("Why did Hagar flee from Sarai?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Sarai dealt hardly with her");

    Console.WriteLine("What did the Angel of the Lord instruct Hagar to do?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("To return to Sarai and submit to her");

    Console.WriteLine("What was the Lord’s promise to Hagar?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("That her seed will be multiplied");

    Console.WriteLine("What was the name of Hagar's son in Genesis 16?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Ishmael, because the Lord heard her affliction");

    Console.WriteLine("What was prophesied about Ishmael in Genesis 16?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("And he will be a wild man; his hand will be against every man, and every man's hand against him; and he shall dwell in the presence of all his brethren.");

    Console.WriteLine("How old was Abram when Hagar bore him a son?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Abram was fourscore and six years old, when Hagar bare Ishmael to Abram.");

    Console.WriteLine("When Abram was 90 years old and nine, what did God do?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The LORD appeared to Abram, and said unto him, I am the Almighty God; walk before me, and be thou perfect.");

    Console.WriteLine("What was Abram's name changed to?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Abraham");

    Console.WriteLine("Did God promise to give Abraham and his seed the land of Canaan?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He did");

    Console.WriteLine("What was Sarai's name changed to?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Sarah");

    Console.WriteLine("Why was Abraham doubtful about getting more children?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("His age");

    Console.WriteLine("What was to be the name of Abraham and Sarah's next child?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Isaac");

    Console.WriteLine("How did God manifest in Genesis 18?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("As three men");

    Console.WriteLine("What did God say he would do if there were any righteous persons in Sodom and Gomorrah ");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He said he would spare the whole city even if some were righteous ");

    Console.WriteLine("Why did the men of Sodom and Gomorrah surround Lot’s house?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("They sought to assault the Angels taking rest there");

    Console.WriteLine("When Lot attempted to defend the Angels what happened?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The Angels pulled him inside the house and struck the men at the door with blindness, so they could not find the door ");

    Console.WriteLine("What did the Angels tell Lot when he fled Sodom and Gomorrah");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Not to look back and to flee far from there");

    Console.WriteLine("What city did Lot flee to?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Zoar");

    Console.WriteLine("What rained on Sodom and Gomorrah?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Fire and Brimstone");

    Console.WriteLine("What happened to Lot’s wife?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("She looked back and become a pillar of salt");

    Console.WriteLine("Why did Abimelech send Sarah back to Abraham?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("God came to him in a dream and told him to");

    Console.WriteLine("What else did Abimelech give Abraham?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Cattle and servants");

            }

            static void Genesis20to30quiz()
        {


    Console.WriteLine("How old was Abraham when Isaac was born");
    string answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was 100 years old ");

    Console.WriteLine("What did Abraham do when Isaac was weaned?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He made a great feast the same day");

    Console.WriteLine("Why did Abraham send Hagar away?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Sarah wanted her sent away, God told him to hearken to her voice");

    Console.WriteLine("When Hagar ran out of water, what happened?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("God sent an angel to show her to a well of water");

    Console.WriteLine("Where did Hagar's son grow up?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The wilderness of Paran");

    Console.WriteLine("Was he an archer?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes he was");

    Console.WriteLine("Did Abimelech seek to make a covenant with Abraham?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes he did");

    Console.WriteLine("What was the well that Abraham built called?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Beer-sheba");

    Console.WriteLine("Where did Abraham and Abimelech make their covenant?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Beer-sheba");

    Console.WriteLine("What did Abraham plant in Beer-sheba?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("A grove");

    Console.WriteLine("Which land was Abraham instructed to take his son into?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The land of Moriah");

    Console.WriteLine("When he was going to sacrifice his son, what did the Angel do?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He stopped him and showed him to a ram to sacrifice");

    Console.WriteLine("Why did God do this?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("To test Abraham's faithfulness");

    Console.WriteLine("What did he call the place where he was going to sacrifice his son?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Jehovah-Jireh");

    Console.WriteLine("How long did Sarah live?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("127 years");

    Console.WriteLine("Where did Sarah die?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Kitjath-arba: otherwise known as Hebron in the land of Canaan");

    Console.WriteLine("Where was Sarah buried?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("In the field of Machpelah");

        }

    static void Matthew1to10quiz()
     {

    Console.WriteLine("Who was Mary's husband?");
    string answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Joseph");

    Console.WriteLine("Who was Joseph's father?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Jacob");

    Console.WriteLine("How many generations are there from Abraham to David?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Fourteen generations");

    Console.WriteLine("How many generations are there from David to the carrying away into Babylon?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Fourteen generations");

    Console.WriteLine("How many generations are there from the carrying away into Babylon unto Christ?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Fourteen generations");

    Console.WriteLine("How was Jesus conceived?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Mary was found with child of the Holy Ghost");

    Console.WriteLine("Did an angel visit Joseph to confirm this to him?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes");

    Console.WriteLine("What did the angel say to Joseph in his dream?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("To call the baby Jesus, because he will save His people from their sins");

    Console.WriteLine("What does Emmanuel mean?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("God with us");

    Console.WriteLine("Is it true Joseph did not know his wife until Jesus was born?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Yes");

    Console.WriteLine("Where was Jesus born?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("In Bethlehem of Judaea");

    Console.WriteLine("Who was the ruling king at that time?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Herod");

    Console.WriteLine("Where did the wise men come from?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("From east to Jerusalem");

    Console.WriteLine("What did they refer to Him as when trying to find him?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("King of the Jews");

    Console.WriteLine("What else did they say?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("That they saw His star in the East and came to worship Him");

    Console.WriteLine("How did Herod feel when he heard these things?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was troubled, all of Jerusalem as well");

    Console.WriteLine("What did he do when he heard this?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He summoned the chief priests and scribes to find out where Christ would be born");

    Console.WriteLine("What was their response?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Bethlehem of Judaea");

    Console.WriteLine("Who sent the wise men to Bethlehem to find Jesus?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("King Herod");

    Console.WriteLine("How did they find Jesus?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("By following the star that they saw in the East");

    Console.WriteLine("What did they do when they found him?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("They presented him with gold, frankincense and myrrh");

    Console.WriteLine("What did God warn the wise men of in a dream?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Not to return to Herod");

    Console.WriteLine("What was their response to God’s message in their dream?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("They departed into their own country another way");

    Console.WriteLine("After this, what did the angel say to Joseph in a dream?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He told him to take Jesus and Mary to Egypt, as King Herod would like to seek out Jesus to destroy him");

    Console.WriteLine("How long did they stay in Egypt?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("Until King Herod died");

    Console.WriteLine("What prophecy did this fulfill?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("The Lord had said through his prophet Out of Egypt have I called my son");

    Console.WriteLine("What did Herod do when he saw that the wise men had mocked him?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("He was exceeding wroth, and slew all the children that were in Bethlehem, and in all the coasts thereof, from two years old and under");

    Console.WriteLine("What prophecy did this slaughter fulfill?");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("“In Rama was there a voice heard, Lamentation, and weeping, and great mourning, Rachel weeping for her children, And would not be comforted, because they are not.” This prophecy came from Jeremy the prophet");

    Console.WriteLine("");
    answer = Console.ReadLine();
    Console.WriteLine(answer); 
    Console.WriteLine("");

    }



            }
        }
    }
