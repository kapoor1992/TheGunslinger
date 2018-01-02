using System;
using System.Threading;

namespace TheGunslinger {
    public class Story {
        private static readonly int sleepTime = 2000;
        private static readonly int chapters = 8;
        private static readonly int chapterOneGoal = 5;
        private static readonly int chapterThreeGoal = 4;

        private Roland roland;
        private string[] chapterHeaders;
        private State[] chapterOne;
        private State[] chapterTwo;
        private State[] chapterThree;
        private State[] chapterFour;
        private State[] chapterFive;
        private State[] chapterSix;
        private State[] chapterSeven;
        private State[] chapterEight;
        private int chapterOneProgress;
        private int chapterThreeProgress;
        private int chapterSevenProgress;
        private int chapterSevenGoal;

        public Story() {
            roland = new Roland();

            chapterHeaders = new string[chapters];

            createChapterOne();
            createChapterTwo();
            createChapterThree();
            createChapterFour();
            createChapterFive();
            createChapterSix();
            createChapterSeven();
            createChapterEight();
        }

        public void play() {
            Console.WriteLine(chapterHeaders[0] + "\n");
            playChapterOne();

            Console.WriteLine(chapterHeaders[1] + "\n");
            Thread.Sleep(sleepTime);
            playChapterTwo();

            Console.WriteLine(chapterHeaders[2] + "\n");
            Thread.Sleep(sleepTime);
            playChapterThree();

            Console.WriteLine(chapterHeaders[3] + "\n");
            Thread.Sleep(sleepTime);
            playChapterFour();

            Console.WriteLine(chapterHeaders[4] + "\n");
            Thread.Sleep(sleepTime);
            playChapterFive();

            Console.WriteLine(chapterHeaders[5] + "\n");
            Thread.Sleep(sleepTime);
            playChapterSix();

            Console.WriteLine(chapterHeaders[6] + "\n");
            Thread.Sleep(sleepTime);
            playChapterSeven();

            Console.WriteLine(chapterHeaders[7] + "\n");
            Thread.Sleep(sleepTime);
            playChapterEight();
        }

        private void playChapterOne() {
            State current = chapterOne[0];
            string response;

            while (chapterOneProgress < chapterOneGoal) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    if (current.action == 1) {
                        roland.drinkWater();
                    } else if (current.action == 2) {
                        do {
                            response = Console.ReadLine();
                        } while (response != "1" && response != "2");

                        Console.WriteLine();

                        if (response == "1") {
                            roland.replenishWater();
                        } else {
                            roland.drinkWater();
                            chapterOneProgress++;
                        }

                        if (roland.water < 0) {
                            Console.WriteLine("Your body cannot go on any longer. You lay on the path, never to wake again.");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }
                    Console.WriteLine(roland);
                    Console.WriteLine();
                }

                current = chapterOne[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterTwo() {
            State current = chapterTwo[0];
            string response;

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    if (current.action == 0) {
                        do {
                            response = Console.ReadLine();
                        } while (response != "1" && response != "2");

                        Console.WriteLine();

                        if (response == "2") {
                            current = chapterTwo[current.next[1]];
                            continue;
                        }
                    } else if (current.action == 1) {
                        roland.fireBullets(1);
                        Console.WriteLine(roland);
                        Console.WriteLine();
                    } else if (current.action == 2) {
                        roland.replenishWater();
                        Console.WriteLine(roland);
                        Console.WriteLine();
                    }
                }

                current = chapterTwo[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterThree() {
            State current = chapterThree[0];
            string response;

            while (chapterThreeProgress < chapterThreeGoal) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    do {
                        response = Console.ReadLine();
                    } while (response != "1" && response != "2");

                    Console.WriteLine();

                    if (response == "1") {
                        Console.WriteLine("You couldn't scavenge any water today.");
                    } else {
                        chapterThreeProgress++;
                    }

                    roland.drinkWater();

                    if (roland.water < 0) {
                        Console.WriteLine("Your body cannot go on any longer. You lay on the path, never to wake again.");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                    Console.WriteLine(roland);
                    Console.WriteLine();
                }

                current = chapterThree[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterFour() {
            State current = chapterFour[0];
            string response;

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    if (current.action == 0) {
                        do {
                            response = Console.ReadLine();
                        } while (response != "1" && response != "2");

                        Console.WriteLine();

                        if (response == "2") {
                            current = chapterFour[current.next[1]];
                            continue;
                        }
                    } else if (current.action == 1) {
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                current = chapterFour[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterFive() {
            State current = chapterFive[0];
            string response;

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    do {
                        response = Console.ReadLine();
                    } while (response != "1" && response != "2");

                    Console.WriteLine();

                    if (response == "2") {
                        current = chapterFive[current.next[1]];
                        continue;
                    }
                }

                current = chapterFive[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterSix() {
            State current = chapterSix[0];
            string response;

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    if (current.action == 0) {
                        do {
                            response = Console.ReadLine();
                        } while (response != "1" && response != "2");

                        Console.WriteLine();

                        if (response == "2") {
                            current = chapterSix[current.next[1]];
                            continue;
                        }
                    } else if (current.action == 1) {
                        roland.fireBullets(2);
                        Console.WriteLine(roland);
                        Console.WriteLine();
                    }
                }

                current = chapterSix[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterSeven() {
            State current = chapterSeven[0];
            string response;

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                if (current.action != -1) {
                    if (current.action == 0) {
                        chapterSevenProgress++;
                        roland.fireBullets(1);
                        Console.WriteLine(roland);
                        Console.WriteLine();

                        if (roland.bullets <= 0) {
                            if (chapterSevenProgress + 1 >= chapterSevenGoal) {
                                current = chapterSeven[current.next[1]];
                            } else {
                                current = chapterSeven[current.next[2]];
                            }

                            continue;
                        } else if (chapterSevenProgress >= chapterSevenGoal) {
                            current = chapterSeven[current.next[2]];
                            continue;
                        }
                    } else if (current.action == 1) {
                        Console.ReadLine();
                        Environment.Exit(0);
                    } else if (current.action == 2) {
                        do {
                            response = Console.ReadLine();
                        } while (response != "1" && response != "2");

                        Console.WriteLine();

                        if (response == "2") {
                            current = chapterSeven[current.next[1]];
                            continue;
                        }
                    }
                }

                current = chapterSeven[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void playChapterEight() {
            State current = chapterEight[0];

            while (current.next[0] != -1) {
                Thread.Sleep(sleepTime);
                Console.WriteLine(current.data);
                Console.WriteLine();

                current = chapterEight[current.next[0]];
            }

            Thread.Sleep(sleepTime);
            Console.WriteLine(current.data);
            Console.WriteLine();
        }

        private void createChapterOne() {
            chapterHeaders[0] = "***** CHAPTER ONE: THE CIRCLE OPENS *****";

            chapterOneProgress = 0;

            chapterOne = new State[6];
            chapterOne[0] = new State("He can't keep up this pace for long. He must know it. I will put an end to him.", new int[] { 1 });
            chapterOne[1] = new State("This desert is unbearably hot. I must not give in to dehydration.", new int[] { 2 });
            chapterOne[2] = new State("*Checks bag.*", new int[] { 3 }, 0);
            chapterOne[3] = new State("You take a drink and load your guns.", new int[] { 4 }, 1);
            chapterOne[4] = new State("I see nothing but barren land this morning. Should I scavenge for water [1] or continue to chase the Man in Black [2]?", new int[] { 5 }, 2);
            chapterOne[5] = new State("It's getting late. I'm going to light a fire and rest for the night.", new int[] { 4 });
        }

        private void createChapterTwo() {
            chapterHeaders[1] = "***** CHAPTER TWO: LOOKING BACK *****";

            chapterTwo = new State[8];
            chapterTwo[0] = new State("Finally, something noteworthy. It's a small farm up ahead. It may be a trap set by the Man in Black.", new int[] { 1 });
            chapterTwo[1] = new State("I need to make a decision before the farmer makes one for me. Should I kill him [1] or attempt to palaver [2]?", new int[] { 2, 3 }, 0);
            chapterTwo[2] = new State("You slowly approach the farm. He's arguing with some crow in the kitchen. It takes less than half a second for you to unholster your left gun and fire it into the side of his skull. The crow flies out a window while screaming about murder.", new int[] { 4 }, 1);
            chapterTwo[3] = new State("You slowly approach the farm, never taking your hand off your right gun. You declare yourself a Gunslinger of Gilead. The farmer quickly steps outside with a crow on his left shoulder. He invites you inside.", new int[] { 5 });
            chapterTwo[4] = new State("You walk inside. You see nothing out of the ordinary. No trace of the Man in Black. You realize the paranoia you hold after Lud. The town that you massacred after it was found to be a trap set by the Man in Black. You eat spare meat leftover by the farmer and lay in his bed to spend the night. You don't sleep well.", new int[] { 6 });
            chapterTwo[5] = new State("He tells you that his name is Brown and his crow is named Zolton. You tell him that you are on a quest to enter the Dark Tower and that your name is Roland Deschain. You are the last of the Gunslingers, the men responsible for guarding against evil in the land of Mid-World. You originated from the fallen kingdom of Gilead. He recites a short prayer wishing you success because the world is falling into hard times. You share your story of the town Lud, a trap set by the Man in Black. You tell Brown that you had to execute each member of the town in order to survive. You are glad that you did not succumb to pessimist thoughts when deciding what action to take when approaching this farm. Brown and Zolton share their story of seeing the Man in Black cross the farm and how the shrubs nearby wilted as he strutted past them. He did not seem to take an interest in the farm. You eat dinner with the farmer and the crow, and sleep in a spare bunk for the night.", new int[] { 6 });
            chapterTwo[6] = new State("You fill up your waterbag from the farmer's well.", new int[] { 7 }, 2);
            chapterTwo[7] = new State("You start heading down the road. You notice the land is even drier and don't see any source of water ahead.", new int[] { -1 });
        }

        private void createChapterThree() {
            chapterHeaders[2] = "***** CHAPTER THREE: THIRST *****";

            chapterThreeProgress = 0;

            chapterThree = new State[2];
            chapterThree[0] = new State("The land looks very dry this morning. Should I scavenge for water [1] or continue to chase the Man in Black [2]?", new int[] { 1 }, 0);
            chapterThree[1] = new State("It's getting late. I'm going to setup camp for the night.", new int[] { 0 });
        }

        private void createChapterFour() {
            chapterHeaders[3] = "***** CHAPTER FOUR: THE BOY *****";

            chapterFour = new State[5];
            chapterFour[0] = new State("You wake up to a boy forcing water down your throat. You knock the cup away, reach for your guns and aim at the boy. Do you shoot [1] or palaver [2]?", new int[] { 1, 2 }, 0);
            chapterFour[1] = new State("You fire a shot from your right gun. He drops immediately and the floor around you collapses. You are engulfed in darkness and are crushed to death.", new int[] { 1 }, 1);
            chapterFour[2] = new State("You ask the boy his name. He tells you to follow him immediately, this place is a trap set by the Man in Black. A waiting demon will kill them both if they do not leave. You follow him out the small room.", new int[] { 3 });
            chapterFour[3] = new State("You discover that the boy's name is Jake and he is from another world. He remembers dying in a car accident in New York. You do not know what a car is or where New York is. You know from your Gunslinger training that there are other worlds and that Jake must have been transplanted to this way station in Mid-World by some unknown power after his death.", new int[] { 4 });
            chapterFour[4] = new State("You see that the land ahead is noticably wetter and that you will no longer have to scavenge for water. You and Jake rest for the night and you decide that you will take him with you in the morning.", new int[] { -1 });
        }

        private void createChapterFive() {
            chapterHeaders[4] = "***** CHAPTER FIVE: THE SUCCUMBUS *****";

            chapterFive = new State[4];
            chapterFive[0] = new State("You and Jake walk for a long time. Time itself is very strange in Mid-World. What seems like an hour can seem like only a minute or as long as a full day.", new int[] { 1 });
            chapterFive[1] = new State("You and Jake approach a mountainside with a monolith nearby. You recognize it as an oracle by its markings. Do you leave Jake to gain clairvoyant insight [1] or do you stop and rest for the night [2]?", new int[] { 2, 3 }, 0);
            chapterFive[2] = new State("You approach the monolith. You feel a warmth grow as you approach its face. You hear a voice tell you about the Man in Black. As you suspected, you know him as Marten. He was the dark magician who helped overthrow your homeland of Gilead. The voice also tells you that Marten isn't important to pursue and that the Dark Tower is calling for you.", new int[] { 3 });
            chapterFive[3] = new State("You and Jake setup camp for the night.", new int[] { -1 });

        }

        private void createChapterSix() {
            chapterHeaders[5] = "***** CHAPTER SIX: THE MAN IN BLACK *****";

            chapterSix = new State[4];
            chapterSix[0] = new State("You awake to Marten standing above you and Jake. Do you fire two shots at him [1] or palaver [2]?", new int[] { 1, 2 }, 0);
            chapterSix[1] = new State("Before the blink of an eye, you fire two rounds at Marten. He laughs and waves the bullets to curve around him.", new int[] { 2 }, 1);
            chapterSix[2] = new State("He tells you to hurry up as he needs to talk with you alone. He's tired of toying with you and tells you that he will meet you after Jake is dead. Before you can argue, he waves away a group of rocks in the mountainside. A cavern is revealed and he disappears into it.", new int[] { 3 });
            chapterSix[3] = new State("You and Jake follow. You see a small railway hand car on a track leading into darkness, Marten is nowhere to be seen. You both get in. Jake will be responsible for driving while you stay on guard.", new int[] { -1 });
        }

        private void createChapterSeven() {
            chapterHeaders[6] = "***** CHAPTER SEVEN: THE CLIMB *****";

            chapterSevenProgress = 0;

            chapterSevenGoal = (new Random()).Next(1, 5);

            chapterSeven = new State[6];
            chapterSeven[0] = new State("You know that this mountain is known to house slow mutants. They don't like trespassers. You two are watching carefully.", new int[] { 1 });
            chapterSeven[1] = new State("After some time, you see a mutant grab the side of the hand car. You fire a single round. The mutant recedes into the darkness nowhere to be seen.", new int[] { 1, 2, 3 }, 0);
            chapterSeven[2] = new State("You are out of bullets. You join Jake at the controls and frantically pump the accelerator. More and more mutants slow it down and finally manage to tip the hand car. Both you in Jake perish in the darkness.", new int[] { 2 }, 1);
            chapterSeven[3] = new State("You see the track ending in a drop. There is a rope ladder on the other side of the abyss. You jump and hold on to the last rung. Jake jumps and is hanging on by only your arm. The rope is starting to snap. Do you try to quickly climb with Jake [1] or let him fall and go up alone [2]?", new int[] { 4, 5 }, 2);
            chapterSeven[4] = new State("You instruct Jake to hang on to your left foot and you grab the next rung with your right arm. It snaps. Both of you fall to your deaths.", new int[] { 4 }, 1);
            chapterSeven[5] = new State("You let go of Jake. He does not scream or curse. But he looks you knowingly in the eyes before he is engulfed in darkness. You climb up the ladder and see Marten standing in front of you at the top. He has a smile on his face and motions you to follow him through the cavern exit. You glance behind you briefly, knowing that you failed the boy, and follow the magician.", new int[] { -1 });
        }

        private void createChapterEight() {
            chapterHeaders[7] = "***** CHAPTER EIGHT: KA *****";

            chapterEight = new State[2];
            chapterEight[0] = new State("You step into a circle of stones with Marten. Once you both sit on the dusty rock floor, the surroundings blur and there is nothing but the two of you. He mockingly tells you how sorry he is for the death of Jake. He then pulls out a stack of cards and says that your role in this great game is not yet over. He flips over three cards. They are The Prisoner, The Lady of Shadows, and The Sailor. He says you are to meet all three as the next steps in the goal to reach the tower. He also tells you that The Crimson King is getting close to collapsing the tower and all of the worlds along with it. He tells you to head east and that their paths will meet again. Then, perhaps, one of them can finally kill the other.", new int[] { 1 });
            chapterEight[1] = new State("You awake. Marten is gone, there are bones left where he sat. You kick over his remains in frustration and look back at the cavern once more before beginning the descent down the mountain. You head east.", new int[] { -1 });
        }
    }
}
