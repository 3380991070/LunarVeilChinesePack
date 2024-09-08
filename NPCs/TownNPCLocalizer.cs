﻿using Stellamod.NPCs.Bosses.Ereshkigal;
using Stellamod.NPCs.Bosses.Zui.Projectiles;
using Stellamod.NPCs.Town;

namespace LunarVeilChinesePack.NPCs;
public class TownNPCLocalizer : ModSystem {
    public override void Load() {
        #region Aimacra 安魅凯拉
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetBestiary), new() {
            { "Aimacra??? From Diari?? Crazy", "填入汉化文本" },
            { "Aimacra", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.GetChat), new() {
            { "They also have fox ears like me lmao", "填入汉化文本" },
            { "This world seems a bit off don't you think?", "填入汉化文本" },
            { "I'm not one to brag but this place is so much better than Ekrose", "填入汉化文本" },
            { "Did Sirestias ask me to find her again?", "填入汉化文本" },
            { "Yeah I've been traveling while you were out.", "填入汉化文本" },
            { "Go play Diari on steam? I have no idea what that means", "填入汉化文本" },
            { "Do people think I'm not into pans?", "填入汉化文本" },
            { "Sooo can we forget about everything that happened in Ekrose?", "填入汉化文本" },
            { "I am really sorry for what we went through but now were here you know?", "填入汉化文本" },
            { "Sirestias went out again, and this time I'm not finding her.", "填入汉化文本" },
            { "Hey could you go do something, I'm about to get dressed, but honestly I say that like you haven't seen me before.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Aimacra), nameof(Aimacra.SetNPCNameList), new() {
            // 安魅凯拉有三个名字,  一个是 Aimacra, 一个是 Aimacra, 一个还是 Aimacra
            { "Aimacra", "填入汉化文本" },
            { "Aimacra", "填入汉化文本" },
            { "Aimacra", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.SetChatButtons), new() {
            { "Talk", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Aimacra), nameof(Aimacra.OnChatButtonClicked), new() {
            { "Heyyy at least we're out of Ekrose alive! I'm glad Vixyl is safe back at the main house.", "填入汉化文本" },
            { "I hate being Sirestias's Assassin.. Speaking of I met a guy named Veldris and he's totally cool!", "填入汉化文本" },
            { "I'll be back I may go to look for some new stuff underground. ", "填入汉化文本" },
            { "What is a thug shaker? To shake or not to shake? Sometimes I wonder if life truly does give lemons.", "填入汉化文本" },
            { "What class would I even be? ", "填入汉化文本" },
            { "Hey sorry for what may of happened on Ekrose but I hope we can still be friends and make up to each other.", "填入汉化文本" },
            { "STARBOMBERS ARE ON THIS PLANET TOOOOO!!!", "填入汉化文本" },
            { "I totally haven't been playing geometry dash.", "填入汉化文本" },
            { "I've seen some weird things in my life, but never would I have thought Fenix would be more chronically horny than Sirestias, but to be fair Sirestias just gets more power doing that.", "填入汉化文本" },
            { "I hate being part human.", "填入汉化文本" },
        });
        #endregion
        #region Bordoc 波尔杜克
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetBestiary), new() {
            { "Steaming from the depths", "填入汉化文本" },
            { "Bordoc the eternal blacksmith", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "BRMMMM", "填入汉化文本" },
            { "Everyone always uses me but never asked how I'm able to talk.. ", "填入汉化文本" },
            { "I don't care I need to gamble", "填入汉化文本" },
            { "My armors are the best in the lands", "填入汉化文本" },
            { "Sirestias and Aimacra game by recently and they laughed at me because they thought my shop was useless", "填入汉化文本" },
            { "Im always feeling hot!", "填入汉化文本" },
            { "Heh, nobody is as good as me", "填入汉化文本" },
            { "Burning Burning, heat and heat", "填入汉化文本" },
            { "I'm inpenetrable", "填入汉化文本" },
            { "Damn we have some hot shit here", "填入汉化文本" },
            { "Only I know that Gothivia has so many barriers between her and the rest of the world, nobody will be able to kill her.", "填入汉化文本" },
            { "Those idiot gintze have made a horrible decision, now they can't use my armors I made for them.", "填入汉化文本" },
            { "KRMMMKTEYYYMMMM BRMMMMM", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Bordoc), nameof(Bordoc.SetNPCNameList), new() {
            { "Blacksmith BORDOC", "填入汉化文本" },
            { "Blacksmith BORDOC", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.SetChatButtons), new() {
            { "Heart of the Morrow", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Bordoc), nameof(Bordoc.OnChatButtonClicked), new() {
            { "I want you to prove to me you're ready to obtain this, I've given you a broken core, if you restore its power, it's all yours. Show me your determination to be Gothivia's doll! You won't be the first to fail.. And maybe she'll come to thank you one day. ", "填入汉化文本" },
        });
        #endregion
        #region BoundGia 受缚的吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.OnKill), new() {
            { "Im being taken away help!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.SetBestiary), new() {
            { "A bound scientist lurking in the Virulent", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(BoundGia), nameof(BoundGia.GetChat), new() {
            { "Oh goodness thank you for saving me. I dont know how long I was tied up... I got stranded down here by a bunch of scouts I presume are from the morrow. I really caused a mess this time but I am really glad you saved me. D'you have a place to stay?", "填入汉化文本" },
        });
        #endregion
        #region CellConverter 分子转换器
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetBestiary), new() {
            { "Burning in a magical laboratory", "填入汉化文本" },
            { "The Cell converter", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.GetChat), new() {
            { "KRTTCAVSJKSC", "填入汉化文本" },
            { "I WANT SCRAP", "填入汉化文本" },
            { "MAKE YOUR SCRAP TOKENS FOR TRADE. KRM", "填入汉化文本" },
            { "YEEERRRM", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetNPCNameList), new() {
            { "Cell Converter", "填入汉化文本" },
            { "Cell Converter", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.SetChatButtons), new() {
            { "Put in scrap token", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeFullName(typeof(CellConverter).FullName, nameof(CellConverter.OnChatButtonClicked), new() {
            { "Weapon Converted!", "填入汉化文本" },
            { "KRRRT, Sensors say you have inputed a token, here you go per request.", "填入汉化文本" },
            { "Womp womp, looks like nothing for you!", "填入汉化文本" },
            { "Error, try again.", "填入汉化文本" },
            { "Put in another token.", "填入汉化文本" },
        });
        #endregion
        #region Delgrim 戴尔格林
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetBestiary), new() {
            { "A magical engineer huh?", "填入汉化文本" },
            { "Delgrim the eternal engineer.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.GetChat), new() {
            { "You're chill aren't ya?", "填入汉化文本" },
            { "Everyone comes in for the same stuff, come and go please.", "填入汉化文本" },
            { "Another visitor?", "填入汉化文本" },
            { "What goes on in the world nowadays?", "填入汉化文本" },
            { "I don't mean trouble, but do as you please.", "填入汉化文本" },
            { "...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Magical Engineer Delgrim", "填入汉化文本" },
            { "Magical Engineer Delgrim", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.SetChatButtons), new() {
            { "Old Tales", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Delgrim), nameof(Delgrim.OnChatButtonClicked), new() {
            { "An old time there was a thriving capital, we used to call it the Harboring Morrow. It was a thriving city under the protection of Gothivia, Verlia, and Irradia. I used to be a member. Gothivia loved every one of us, Verlia would be off directing armies and Irradia well she spent time making electronics. ", "填入汉化文本" },
            { "Irradia would make amazing tech, and I would come to every show she would host and watch her mechanic sword fights and spare parts, Verlia would sometimes participate and tear all of them apart. Verlia was just too good of a swordsman.", "填入汉化文本" },
            { "Gothivia would always come down at 10 A.M in the morning to greet all the city members, it used to be the time of my life. She'd give us goodies and Rek would come by with his binding light to empower the underground and brighten things up. ", "填入汉化文本" },
            { "Verlia and Gothivia are sisters, although they don't look it anymore, they used to be twins yet they couldn't be different from each other. Verlia was always rambunctious and outgoing while Gothivia was a calm and loving soul, the two got along.", "填入汉化文本" },
            { "Of all the inventions Irradia made, by far my favorite was a rendition of Gothivia's Rek called Havoc. It was a magnificent beast. It held it's own against Verlia in the shows, if only I could go back to those days. ", "填入汉化文本" },
            { "Verlia always would be training the army, the gintze army wasn't exactly the most reliable mainly because of Verlia's idiocity and lack of care for danger. The army would always charge head first without a care for defense. I wonder where the army was when we were defending against the Carian warriors and knights", "填入汉化文本" },
            { "Some days I look back on the Harboring Morrow and wonder why we fell so hard. I remember BORDOC, an excellent blacksmith but too arrogant to read his ways. Irradia taught me some amazing things I carry with me today and all the people. the people.. ", "填入汉化文本" },
            { "You know, I had loved Irradia, until we seperated through war our connection was magically I would say. Damn witches and their artistry. I don't hate magic, but its the reason I lost so much. That commander, I will never forget the smirk on that face. So called Fenix and her army of Carian knights. ", "填入汉化文本" },
            { "One day in the Harboring Morrow, the most joyous of days, some collectors came back infected by some strange disease, as you may know now it's called the Virulent. An acid like corruption that eats at the soul. It tore our village apart like the black plague. It weakened us, right before a Carian army swept us away at our worst, we stood no chance.", "填入汉化文本" },
            { "Verlia one day left the Morrow to search and make peace with the witches in the upcoming villages, she was by far the most magical out of the three of them, so she would stand a chance to help, when she came back, she was out of her mind.", "填入汉化文本" },
            { "When Verlia came back from her excursion, she well, gave information that changed the course of our lives. Me being in a relationship with Irradia I was able to be let in on that information. She shared to us a tome from a small witch village. This would a fatal mistake.", "填入汉化文本" },
            { "Verlia's excursion took place right when the corruption started occuring, she went to look for a way to heal the damaged. Gothivia would do her best to heal everyone but she was only one person in the biggest capital in terraria. ", "填入汉化文本" },
            { "One harrowing day, a fox appears at the doorstep of Verlia and Gothivia's abode. I knew my eyes decieved me when I had seen the fox transform into a tall Nero, they are like human cats but I thought they'd been extinct for millenia! ", "填入汉化文本" },
            { "When a fox arrived on the doorsteps of our beloved, The fox lady brings out what I can only think was a lantern and all I could make out inside that room was a giant blue flash and the screams of Gothivia. This was the last time anyone heard of Verlia.", "填入汉化文本" },
            { "After what I call the 'blue flash,' everyone hurried to a sign of screaming in the middle of the night. We all come to see Gothivia crying with a note in her hand and the fox lady. She introduced herself as Fenix. ", "填入汉化文本" },
            { "Fenix was a tall statured woman yet extremely menacing, at times a lot of us thought she may have been more powerful than Gothivia, but deep down Gothivia's suppressed feelings for her family would probably overcome that. ", "填入汉化文本" },
            { "The illnesses started to rack up and since Verlia disappeared, our Harboring Morrow was not complete, there was nobody to keep our armies in check, Gothivia wasn't mentally there anymore and Irradia was trying her best to get everyone to calm down. It was a horrible time.", "填入汉化文本" },
            { "Irradia did explain what happened to Verlia, but I thought it was just downright evil. Fenix trapped Verlia's soul inside a lantern and bounded it to a secret power for experimentation because she stole a book from their village. We'll never get to see her again will we?", "填入汉化文本" },
            { "I think Irradia's way of coping to the loss of Verlia was teaching me now that Im starting to recollect. She may have used it as a way of reflecting, and I didn't see that she was hurting yet I was always there for her.", "填入汉化文本" },
            { "I kept on living, hell I even got sick from the Virulent, yet I was Gothivia's last person to get healed from her. Rek eventually got infected too yet since havoc was electronic, he stayed normal. The creatures that lived the best were mostly metallic, its what remains of our old village.", "填入汉化文本" },
            { "After the last healing in from Gothivia, I'd say about 90% of our village was wiped out from the Virulent, our soliders, our love, and will to live all started to fall apart. ", "填入汉化文本" },
            { "I could recall me laying on a bed as I watched our city crumble, Irradia would stay by my side and we'd comfort each other as the world caved in for us.", "填入汉化文本" },
            { "After a while of our suffering in the city Gothivia would leave to seek vengence and power to save her sister, leaving Irradia to be at the helm. Take a guess who arrived not so soon afterwards? Fenix, she came to take what was left of us.", "填入汉化文本" },
            { "Fenix is like a scouraging raven looking for its next feast, and we were on the menu. I was forced to split from my love due to her sacrifices of being a leader. We haven't seen each other since, yet I know she's out there somewhere. No way would she loose to Fenix..", "填入汉化文本" },
            { "The Great Departure, that's what I call the leaving from what was left in our city. As the Carian army approached, we hid through underground tunnels to escape, some of us, including me, haven't gone back to the surface. I was even invited to come to the Fable.", "填入汉化文本" },
            { "Those who made it to the surface from the Great Departure reinvented the Harboring Morrow yet from all the messages from BORDOC, it isn't the same. They close their doors to everyone in fear and they look for Gothivia, she never said where she went.", "填入汉化文本" },
            { "I was in tunnels underground for 10 of my years, now I lay here with all the corpses and electronics that I bear, I've travelled every part of this world except the surface, to ever find Fenix again would send me over my limit.", "填入汉化文本" },
            { "You know, maybe I should have travelled with the rest of the members of the morrow, many of us split up in our escape, many died, hell, maybe I'm the only standing survivor, but I'm here.", "填入汉化文本" },
            { "My creations that I make now are from my explorations, I will find Irradia again, I need to apologize, to say something. These are all for her anyway. If only I could have stopped this from getting this way, maybe I could have stayed against her will.", "填入汉化文本" },
            { "Of all my years to live and ever to live, I will never understand things like Fenix, her torturous additude, why she went to such lengths to kill us, why the infection was so hard to fend off, and why I couldn't stay, these are all for you, Irradia. ", "填入汉化文本" },
        });
        #endregion
        #region Gambit 赌博骰子
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetBestiary), new() {
            { "She loves those ruin medals huh?, so much so that she is now attracted to you :(", "填入汉化文本" },
            { "Zielie the Gambit", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.GetChat), new() {
            { "I love the party girl! Shes really sweet! Umm could you maybe hook us up :(", "我太喜欢派对女孩啦！她又善良又有趣！你觉得你能不能...给我们互相介绍一下？" },
            { "Hii, it is a me, Zielie! I'm frantic at moments but what can you expect when your in a world full of death and loooove?", "嗨~，我叫泽丽！我有时会有点神经质，但在一个充满爱与死亡的世界中这样不是最好了吗！！" },
            { "Ive heard that the morrow is very pretty, I talked to veribloom and she said her society is falling apart though so maybe not.", "听说幽曦之地很漂亮，但我问薇绿的时候她说那里的社会已经快要完全失控了，我还是先不去那里了为妙." },
            { "I have some things on the market for you, I go around collecting items and I get more stuff when you beat bosses and honestly, you seem really cool! :0", "我这里有点好东西卖给你！都是我自己捡来的和你打Boss剩下的东西~你也很棒哟！" },
            { "You know who is responsible for your dice rolling righttt? You know, uh after you beat bosses? Yeah, thats me ya silly lovebug", "就是，你知道你的赌博骰子都是谁在扔对吧？就是我呀你个小傻瓜." },
            { "Can we get married?", "咱们来结个婚，你意下如何？" },
            { "Soo are we gonna get married or are you gonna buy something?", "买点东西吧！难不成你想把自己卖给我？" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Delgrim), nameof(Delgrim.SetNPCNameList), new() {
            { "Zielie", "填入汉化文本" },
            { "Zemmie", "填入汉化文本" },
            { "Zeilie", "填入汉化文本" },
            { "Zielie", "填入汉化文本" },
            { "Wenomechinimasama", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.SetChatButtons), new() {
            { "Marry", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gambit), nameof(Gambit.OnChatButtonClicked), new() {
            { "OMG YOU DOOOO? Aww youre so sweet \nwe can hold off until a bit later :3", "填入汉化文本" },
            { "Aww cmon, don't be so silly, \nlets wait until we fix this world, \nlet me help you out :P", "填入汉化文本" },
            { "Awaaaaaaaaaaaaaaaaaaaaaaaa~ \n(Zielie is too flustered to continue)", "填入汉化文本" },
        });
        #endregion
        #region Gia 吉娅
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetBestiary), new() {
            { "Wow you done messed up this time with the Virulent spill huh.", "填入汉化文本" },
            { "Gia the Scientist", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "她有那么多超棒的机械！我好想要啊." },
            { "A long time ago, I used to experiment with Biotech. It went wrong, and teleported pieces of itself all over the world. You might have found some by now.", "很久之前我还在研究生物科技，但是那件作品出了岔子，残片飞散到了世界各处.你可能已经找到了其中的几片." },
            { "Maybe if you find some of my lost tech, you could craft my original biotech and retry my experiments!", "如果你能找到那些我遗失的科技零件，就能造出我的独创机器，重试我的试验！" },
            { "The guide seems to know too much for a human being. I feel like he has something else connected to him…", "向导知道的实在太多了，他真的只是个人类吗？我感觉有什么其它东西与他有联系..." },
            { "The merchant keeps telling me about this dangerous eye thing. I could just zap it with my Bio laser.", "商人一直在说什么危险的大眼球...它要是敢来，我就让它尝尝我的反生物激光." },
            { "Aimacra seems pretty neat, too bad she's taken", "安魅凯拉看起来不错，可惜她已经有伴了." },
            { "I wouldn't mind hooking up with the Steampunker :)", "蒸汽朋克人也不赖嘛，我想和她试试：）" },
            { "So many spare parts and materials, bring them all to me!", "有多少零件材料就给我拿来多少！" },
            { "I can't believe I let it get loose, I've complicated too many things.", "真不敢相信我居然一时疏忽把“它”放出来了...这下事情复杂了好多." },
            { "Can you go collect some runes for me? I'd love for you to get working.", "给我收集一些符文碎片吧！反正你闲着也是闲着." },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.SetNPCNameList), new() {
            { "Gia", "填入汉化文本" },
            { "Gia", "填入汉化文本" },
            { "Gia", "填入汉化文本" },
            { "Gia", "填入汉化文本" },
            { "Gia", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Gia), nameof(Gia.SetChatButtons), new() {
            { "Trade Rune", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Gia), nameof(Gia.OnChatButtonClicked), new() {
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" }, // 勿动, 下同
            { "I give you my thanks for this Desert artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },

            // 这里应该是 Ice artifact, 但是笨笨作者复制粘贴时忘改了, 导致只能使用 InOrder 的方式改
            { "I give you my thanks for this Sky artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Overworld artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Ocean artifact, I'll research it greatly, heres something in return..", "感谢你帮我找到了这块符文，我会仔细研究它的.这是些回礼，难表谢意..." },
            { "Stellamod/Assets/Sounds/Bliss1", "Stellamod/Assets/Sounds/Bliss1" },
            { "I give you my thanks for this Jungle artifact, it'll help further my reserch to fixing this mess!", "感谢你帮我找到了这块符文.这对我弥补这烂摊子的研究很有帮助！" },
        });
        #endregion
        #region Ginztel 玄铁军官
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.SetBestiary), new() {
            { "Dumbfounded by your strength, the commander retired and came to your base for a visit and a free hotel.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ginztel), nameof(Ginztel.SetNPCNameList), new() {
            { "Gintzia", "填入汉化文本" },
            { "Ginztel", "填入汉化文本" },
            { "Steven Universe", "填入汉化文本" },
            { "Gintzel", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ginztel), nameof(Ginztel.GetChat), new() {
            { "Hehe the Demonilitionist guy is pretty cool, he's got bombs..", "嘿嘿，那个爆破专家不错，他有好多炸弹..." },
            { "Im just peeping around, I might stay for a while..", "俺只是来看看...或者在这住一小会." },
            { "My team was quite weak to say, I apologize for the inconvience", "俺的那帮人好弱啊.真是给你添麻烦了." },
            { "Some of the things I'm selling are from base, we've all taken quite a liking to you all.", "俺卖的东西好多都是是从俺们基地拿来的！俺们都觉得你还是个不错的家伙！" },
            { "If you can kill Gothivia for us we can scavange and steal their items, please help us do that", "如果歌瑟梵挂了俺们就能抢她的东西啦！你一定要赢啊！" },
            { "We may be weak but we still give all of our little praise to Verlia, hence why we stole from her sister..", "俺们不强，但俺们最稀罕薇莉娅，才敢偷她姐姐的东西." },
            { "Could you murder Gothivia in the most brutal fashion possible? She is way too dauntless and carefree, we hate her and she took our home..", "你一定要把歌瑟梵狠狠的揍一顿呀！俺们看着她那副目中无人的表情就来气！她还霸占了俺们的家..." },
        });
        #endregion
        #region Ishtar 狂渊
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ishtar), nameof(Ishtar.SetBestiary), new() {
            { "Entrance", "填入汉化文本" },
            { "The entrance to the Ishtar Citadel", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ishtar), nameof(Ishtar.SetNPCNameList), new() {
            { "Ishtar Pin location", "填入汉化文本" },
            { "Ishtar Pin location", "填入汉化文本" },
        });
        #endregion
        #region Mardenth 玛登斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetBestiary), new() {
            { "One of the 3 Children of Daeden, this one being the most useless", "填入汉化文本" },
            { "Mardenth of the Veil", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.GetChat), new() {
            { "So many cool contraptions she has, I love them!", "填入汉化文本" },
            { "Damn that Sigfried guy.", "填入汉化文本" },
            { "Where's Ereshkigal?", "填入汉化文本" },
            { "Daedus, Jovhia, Daeden? Where'd you all go?", "填入汉化文本" },
            { "I'm quite formiddable you see. I can destroy anything with my hands.", "填入汉化文本" },
            { "I need to study up on my electric magic. If my dad wasn't dead he'd be proud of me. Gosh I wish you were here Daeden", "填入汉化文本" },
            { "I never knew my mom..", "填入汉化文本" },
            { "Why is Jovhia always in the sky?", "填入汉化文本" },
            { "Hey you, get out of here!", "填入汉化文本" },
            { "Scadabble you women harrasser.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Mardenth), nameof(Mardenth.SetNPCNameList), new() {
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
            { "Mardenth", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.SetChatButtons), new() {
            { "Talk", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Mardenth), nameof(Mardenth.OnChatButtonClicked), new() {
            { "Heheheh, I like to eat little wormy guys but they won't stop squiggling. Reminds me of when our dad Daeden left us. ", "填入汉化文本" },
            { "Where did Daedus go?  He left us so long ago. I hope he wasn't swayed by that Harlet Gothivia. She seemed power obsessed and hungry. Maybe that's just me though", "填入汉化文本" },
            { "I might be the only one but, Ereshkigal is kind of hot isn't she? Hell you wouldn't even know would you. You're taste in women is flat.", "填入汉化文本" },
            { "You don't understand how we are. We're higher than all below us, which is everyone except a god. Only they can be held to such high status. Squirm off you worm.", "填入汉化文本" },
            { "I wish Sigfried didn't go insane. He's such an asshole, even our dear Ereshkigal left with him to seal him away...  ", "填入汉化文本" },
            { "Maybe I may be the only person to question the gene pools of these people. Like where do they all look so pretty from??? Im wearing this mask cuz I look like a goblin.", "填入汉化文本" },
            { "I want a beach episode with Zui and Ereshkigal now! ", "填入汉化文本" },
            { "I would want to be more powerful but that takes a lot of training. Anyone who dares to take more than what they are given should be punished. ", "填入汉化文本" },
            { "Those guys in the well? They are trapped down there because they made some goofy deals in their lives to get more power and just like the great Veil people we are, we trapped them away for good.", "填入汉化文本" },
            { "I don't know what the outside world is like.", "填入汉化文本" },
        });
        #endregion
        #region Merena 梅瑞娜
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.SetBestiary), new() {
            { "Magic Magic MAGIC", "填入汉化文本" },
            { "Merena the bewitched sorcerer", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.GetChat), new() {
            { "Funny enough the clothier used to come through here all the time for some of our amazing fabrics", "填入汉化文本" },
            { "I wonder what my sister Sylia is up to nowadays, do you know her?", "填入汉化文本" },
            { "I'm gonna be the very best, like no one ever was... ", "填入汉化文本" },
            { "Fenix is the best queen there will ever be! She gives us all what we want :P", "填入汉化文本" },
            { "This place is so calming, I can't stand it but I would give everything to be near Fenix", "填入汉化文本" },
            { "Aimacra seems pretty cool, she came here recently looking for some brooches", "填入汉化文本" },
            { "Hey uh could you do something for me? I have a little favor, just ask what it is!", "填入汉化文本" },
            { "I've always wanted to be the best witch there is! I've always been outshined by exiles though, including my sisters sadly.", "填入汉化文本" },
            { "I really need to beat my sister in a battle someday.", "填入汉化文本" },
            { "It's strange, the economic system here is almost like communism", "填入汉化文本" },
            { "Damn we have some cool shit here", "填入汉化文本" },
            { "No doubt about it but Fenix is truly the strongest witch in all of the lands, maybe even more powerful than the witch of light in the hallow, I don't like her.", "填入汉化文本" },
            { "Hahh, I remember that goon Verlia, she's kind of dumb but shes at least powerful, I remember she got exiled for stealing tomes, I might need that from her.", "填入汉化文本" },
            { "Can you go collect some runes for me? I'd love for you to get working.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Merena), nameof(Merena.SetNPCNameList), new() {
            { "Merena the Sorcerer", "填入汉化文本" },
            { "Merena the Sorcerer", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), nameof(Merena.SetChatButtons), new() {
            { "Merenas Quest", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_VerliaStart", new() {
            { "What are you standing there for, go kill Verlia! She's an enemy of the royal capital and she has a book I need lmao", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_VerliaComplete", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MorrowStart", new() {
            { "Oh damn thanks! Next on the list I need you to steal an orb from a village in an underground morrowed village, the orb contains a magic unlike any other. I have no idea how it was manifested but it's needed for this tome.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MorrowComplete", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_DustBagsStart", new() {
            { "Woa, the energy is pouring out of this one with seamless orange stripes! How did you even get your hands on this?? Either way thanks, now I just need 100 dust bags, it helps with the brewery.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_DustBagsComplete", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MagicPaperStart", new() {
            { "Neat neat, that shouldn't have been too bad for you I think. Next I need some magical paper, there are magical creatures all over the world of hardmode who drop these, most of them being rare and unique creatures, go get em'!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_MagicPaperComplete", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abyss. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_TomeStart", new() {
            { "OHH Great lmao. Ok we have one more thing we need to do. Legend has it an old thief of this Royal Capital stole an extremely special Carian tome, they stay deep underground hidden far away underneath the abysm. Even if the rumors arent true I'd love for you to find this scroll, it may take years...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "Quest_TomeComplete", new() {
            { "THANK YOU THANK YOU THANK YOU, omg this is the best day of my life! I never knew this actually existed! Were the rumors true??! dsfjhnbhfribdhs- Nevermind who cares anymore, we can both be the best mages ever! I open my shop to you and here, a token of my graditude. ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Merena), "StartQuests", new() {
            { "Hey, I have nothing else for you to do! Thanks for all of your help, have you checked out my shop yet?", "填入汉化文本" },
        });
        #endregion
        #region NaturalWitch 自然女巫
        ForceLocalizeSystem.LocalizeByTypeName(nameof(NaturalWitch), nameof(NaturalWitch.SetBestiary), new() {
            { "A Captain of Gofria's ranks, be careful", "填入汉化文本" },
        });
        #endregion
        #region Ordin 奥丁
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetBestiary), new() {
            { "Steaming from the depths", "填入汉化文本" },
            { "Ordin, The New Monarch", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "Remove yourself from my sight", "填入汉化文本" },
            { "You walk like an infant with no tucas", "填入汉化文本" },
            { "What a pitiful endearment, praise to the ones above.", "填入汉化文本" },
            { "...", "填入汉化文本" },
            { "You are not fit to become a god", "填入汉化文本" },
            { "Oh Sigfried, return in good health or I shall slay you with my own hands from such a succubus!", "填入汉化文本" },
            { "Bring me their Manifestations", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Ordin), nameof(Ordin.SetNPCNameList), new() {
            { "Ordin, Illurian Monarch", "填入汉化文本" },
            { "Ordin, Illurian Monarch", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.SetChatButtons), new() {
            { "Reminisce of Sigfried", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Ordin), nameof(Ordin.OnChatButtonClicked), new() {
            { "Thy is so resilient, unhand me from these this trecherous nagging and take this for thy shall not be astute to your prescence no longer.", "填入汉化文本" },
            { "To be one of the forth or forward, the lands that I rest in reek of falsification of hypocrisy and power.", "填入汉化文本" },
            { "Sigfried was once a young fellow, thy brother in one's eye's and a villian in anothers'.", "填入汉化文本" },
            { "Our sacred castle falls ill to such burning. Our wishes have been grafted under the curse of Sigfried's unveiling.", "填入汉化文本" },
            { "Fall away, dear brother ", "填入汉化文本" },
            { "Mark thy words with caution. Ereshkigal is a loveless harlet who took the life of the brother of many. Yet thy fulfills their prophecy among lovers, hence she is not a false goddess.", "填入汉化文本" },
            { "All our goals are put to rest following the lands of the veil. Finish all those who have wronged our beloved world.", "填入汉化文本" },
            { "Manifest their souls and bring them to my company. You shall be rewarded until the rekoning begs for your place to be silenced. ", "填入汉化文本" },
            { "Niivi, the protector of the lands of the veil, yet curse all upon thy brother to be selfish and steal among those of power and wealth. He was greedy and in his expense payed the lovers' prison.", "填入汉化文本" },
            { "Now I sit ill waiting for the lands of the veil to change.", "填入汉化文本" },
        });
        #endregion
        #region PULSARHOLE 脉 冲 黑 洞
        // 暂无需要强制本地化的内容
        #endregion
        #region Sirestias 希丝忒莉亚
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetBestiary), new() {
            { "Your eternal bonding with this individual resonates with everyone throughout!", "填入汉化文本" },
            { "Sirestias", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.GetChat), new() {
            { "Here to give me some company I see?", "填入汉化文本" },
            { "Hmph how's Aimacra doing? Nevermind I already know that answer.", "填入汉化文本" },
            { "Enjoying yourself?", "填入汉化文本" },
            { "Sometimes I forget you're bounded with me always", "填入汉化文本" },
            { "Its always sweet to see you do things for me", "填入汉化文本" },
            { "...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Sirestias), nameof(Sirestias.SetNPCNameList), new() {
            { "Sirestias", "填入汉化文本" },
            { "Sirestias", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.SetChatButtons), new() {
            { "What do I do next?", "填入汉化文本" },
            { "Give Completion Idol", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Sirestias), nameof(Sirestias.OnChatButtonClicked), new() {
            { "Kill the stone guardian, commander gintzia will soon raid you with his army of failed troops from the govheil. He will be very easy so take him swiftly and beat him into submission hun. ", "填入汉化文本" },
            { " I'd recommend going into the Fabled Swamp over to the right or collecting resources to get ready to fight either Jack or find a sun alter in a desert and prepare for Sunstalker! Zui may be a good person to talk to in the witch village for quest items too :) ", "填入汉化文本" },
            { "Nice babe, I want you to go kill Jack in the Fabled swamp on the right then, you need a wandering essence and he shouldn't be too difficult. ", "填入汉化文本" },
            { "Nice work! I want you to go headhunt a bird in the desert, his name is Sunstalker and they are a bit challenging but less so than the last, collect some mandibles in the desert to make the Sun stone! Find the alter on the surface of a desert!", "填入汉化文本" },
            { "You're next target is Daedus, he's a strong one. Hes a very loyal Guardian to one of the biggest threats here being Gothivia, we need him gone to get to the big fish in the sea. For some reason he holds some power of a singularity so beware. He resides low in the temple in the Fabled Swamp, no extra preperation needed.", "填入汉化文本" },
            { "Oh my gosh nice, so here's where things are going to get difficult. If a blood moon happens we need to exterminate Dreadmire, she spawns after killing a blood cyst during a blood moon, you can also get some terror fragments too! She'll pose too much of a threat if we let her live. She's I think one of the three sisters, formally known as cozmire. She needs to die and after that I'll give some great rewards.", "填入汉化文本" },
            { "We are making big progress now! I don't know if you have been killing other ravenous monsters but I'd recommend doing so as the next one on our list is Verlia but to get to her we have quite a few things to do first. Make yourself a void key and find a temple deep in the ice biome, there should be some loot and hopefully an alter that'll give you a lantern. She was trapped by Fenix but she needs to die so we can bring out Gothivia.", "填入汉化文本" },
            { "Ok you got the lantern! Go to the cathedral overtop the ice biome and summon her at the top at night. This will be our biggest foe yet but I know you can kill her, sorry Aimacra is tired of being my assasin so it's your turn.", "填入汉化文本" },
            { "Oh damn this is great. I think that completes our list for now, check back in with me in Hardmode! We'll purify this world of all danger and create peace and then we can be together and move on. Thank you again.", "填入汉化文本" },
            { "Welp here we go again. So theres a strange issue we have, so Daedus isn't the only barrier to trying to stop us from getting to Gothivia, Aimacra just went and explored around and found some new places and there was this castle underground in a green biome? I noticed Gothivia's marks on it and the Sun hasnt started turning green, could you look at that? There should be some catacombs underground in the desert, ocean and caverns to help power up too.", "填入汉化文本" },
            { "There was a person down there claiming to be Gothiva? Thats strange. Gothivia seems to be making an appearance on the world. Apparently things are changing the skies and things are falling from them, Beware of STARBOMBERS, Aimacra warned me that they were manufactured here as well as Ekrose and you have experience with them.", "填入汉化文本" },
            { "I didn't think Rosemary's creations would've made it here. Ekrose sure does have an affect on this world. I saw some strange disturbance on the left side of the underworld though, can you check that out? I went to talk to Veldris and he told me Sylia may be up to some demonic magic that could ruin our process, so killing her is a good option. ", "填入汉化文本" },
            { "It was a void witch... Interesting. Must be related to that Merena person Aimacra talked about. I haven't been to the Royal Capital much, mainly because it's so far out but maybe we should kill the Queen there, she is definitely extremely powerful but I don't really know how to talk to her, I haven't seen her yet. If you can could you go kill her for us? ", "填入汉化文本" },
            { "Ereshkigal huh? I think I know her, she also isn't supposed to be here. However she got lost I guess we can give her some sense", "填入汉化文本" },
            { "Weheeee! You're doing so well! I can like get off to this! I'm kidding :(. Maybe you can try and explore around some more. We need to prepare for moonlord!", "填入汉化文本" },
            { "I did not expect you to want to kill her honestly. I went and explored around and she seemed nice. Wait you didn't kill her? Oh dang, well she isn't on our list anyway so it's fine lmao. She isn't causing us any issues.", "填入汉化文本" },
            { "Ok ok we got some good stuff done. Time for Gothivia as she's not particularly the worst but she keeps inspiring bad people to do ad things and we need to teach her not to do that.", "填入汉化文本" },
            { "Maybe we shouldn't have killed her, I don't know if there was a reason to kill Niivi. You just wanted weapons and gear? I mean if it helps I guess. She was doing more good than harm", "填入汉化文本" },
            { "Okie dokie, Gothivia has agree to stay calm so we aren't going to assassinate her anymore, I feel bad for killing her sister now. I hope Vixyl doesn't find out.", "填入汉化文本" },
            { "YESSS, we're getting closer to our goals!! Aren't you excited <3", "填入汉化文本" },
            { "I couldnt find anything more so I'll give you an extra token!", "填入汉化文本" },
            { "Please go do something for me, we don't have all day you know ;P", "填入汉化文本" },

        });
        #endregion
        #region UnknownSignal 神秘信号源
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetBestiary), new() {
            { "An Unknown Signal", "填入汉化文本" },
            { "Unknown Signal", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.GetChat), new() {
            { "A static voice confirms the identity of the user, you are in the right place.", "填入汉化文本" },
            { "A static voice confirms the identity of the user, you are in the right place.", "填入汉化文本" },
            { "...", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetChatButtons), new() {
            { "Touch Unknown Circuitry", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(UnknownSignal), nameof(UnknownSignal.SetNPCNameList), new() {
            { "Unknown Signal Source", "填入汉化文本" },
            { "Unknown Signal Source", "填入汉化文本" },
        });
        #endregion
        #region Veldris 维尔迪斯
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.SetBestiary), new() {
            { "Freezing to death", "填入汉化文本" },
            { "Veldris the assassin", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Veldris), nameof(Veldris.GetChat), new() {
            { "Shes got some great cogs", "填入汉化文本" },
            { "Who's next on this list to kill?", "填入汉化文本" },
            { "How are you doing? ", "填入汉化文本" },
            { "I need to gamble a bit more today", "填入汉化文本" },
            { "That Sirestias woman creeps me out.", "填入汉化文本" },
            { "I gotta get to the Royal Capital some day. Maybe they can empower my weapons.", "填入汉化文本" },
            { "So coldddd", "填入汉化文本" },
            { "Hey you, come buy some stuff from me!", "填入汉化文本" },
            { "Im starting to warm up this winter", "填入汉化文本" },
            { "Everyone and all this damn god talk, it makes me crazy", "填入汉化文本" },
            { "Interestingly, I don't know why those sisters all are disconnected, it seems like they're always hiding something", "填入汉化文本" },
            { "I wish I was someone important", "填入汉化文本" },
            { "Sometimes I wanna lead an army you know? I just wanna see Veiizal again", "填入汉化文本" },
            { "You gonna buy something lad?", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetNPCNameList), new() {
            { "Veldris the Calm Assassin", "填入汉化文本" },
            { "Veldris the Calm Assassin", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.SetChatButtons), new() {
            { "Talk", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Veldris), nameof(Veldris.OnChatButtonClicked), new() {
            { "You doing good? I mean it's a hellhole out here. Sometimes I even start to wonder what brings you here. I'm just some lonesome seller, just be sure not to get on someone's deadlist or else I'll be seeing ya. ", "填入汉化文本" },
            { "Everytime I hear someone talk about gods I want to just puke in their faces, like ew. I'm kind of glad that Sirestias woman is getting rid of them. Her and Fenix don't seem all too power driven. Fenix is just revenge driven, and I can respect that.", "填入汉化文本" },
            { "If my weapons we're ever used, they better be in the right hands. My tools were crafted with some Luminull and some special metals, they better hold together- I had to steal some stuff from that Illuria place", "填入汉化文本" },
            { "I'm just gonna rant about this Illuria place honestly. WHY IS THERE A DRAGON JUST ROAMING. Like I thought those went extinct with the the virulent- oh I meant acid. I really just needed some scales but oh noo the watcher of society is there. ", "填入汉化文本" },
            { "Back in my day building this house was my masterpiece, Fenix really gathered up an army just to build this cathedral here and that temple below just to trap some harlet who took her stuff. Down right evil though on Fenix's behalf, maybe overkill. ", "填入汉化文本" },
            { "Some knights visited me the other day talking of this 'peace and formality' and I couldn't take it so I went to the Lunar tree, which for some reason they live on and I stole some fragments and some luminull? It seems pretty powerful and is probably related to Lumi in some way.", "填入汉化文本" },
            { "I love myself commissions, just sayingg if you wanna commission me I'm all available, the last person I went to kill was some goofy guy named Rallad, some girl named Sylia asked me if I could do it for her since she didnt want to be seen, took forever to find him though. ", "填入汉化文本" },
            { "Interestingly enough me and Sylia have fun sometimes, shes pretty nice once you get to know her, sadly she stays away from her sister Merena and the rest of the capital, she's pretty chill. Kind of wanna travel with her though. ", "填入汉化文本" },
            { "The small joys of life comes from not having your house destroyed by some malevolent gods throwing down their trap cards when youre trying to sleep. It makes me annoyed when I have to peek out my window to make sure the black hole isn't going to hit my house.", "填入汉化文本" },
            { "You knowww, I was named Veldris by my friend, I always grew up without a name since my parents died by a stupid raging black hole guy, name was Sepsis I believe? He killed off so much 30 years ago yet I remember it like yesterday.", "填入汉化文本" },
        });
        #endregion
        #region Zui 蕊
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.SetBestiary), new() {
            { "A traveller of the lands who may hold great power", "填入汉化文本" },
            { "Zui the Traveller", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.GetChat), new() {
            { "The dryad is pretty fun after all, she's pretty sweet and helps us with the gardening!", "填入汉化文本" },
            { "We've had to kick a few witches out of this town you know, its quite a shame..", "填入汉化文本" },
            { "I keep going out to find more plants but somehow you're always here when I return. ", "填入汉化文本" },
            { "I'm trying to find a way to stop the corruption and virulent from spreading but I have no fix currently.", "填入汉化文本" },
            { "Hey love, you know you could be collecting stuff for me!", "填入汉化文本" },
            { "Sirestias? Oh um yeahh we go pretty far back.", "填入汉化文本" },
            { "Aimacra is cool too, this is my first time meeting her lol", "填入汉化文本" },
            { "I wouldn't say I'm too powerful, afterall I a just a traveller", "填入汉化文本" },
            { "Sometimes I wonder what they did in Vodhome after we all left. I really have to catch up with Sirestias and the others.", "填入汉化文本" },
            { "Are you here with Sirestias?", "填入汉化文本" },
            { "All these plants are so cool! I did just arrive here before Sirestias, there was some commotion and I think people here are trying to disrupt time and power.", "填入汉化文本" },
            { "Sirestias is a balancer, same goes for me but I like to just collect things.", "填入汉化文本" },
            { "Hey if you collect some items for me I can give you some stuff!", "填入汉化文本" },
            { "Hey can you go collect for me?", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(Zui), nameof(Zui.SetNPCNameList), new() {
            { "Zui The Traveller", "填入汉化文本" },
            { "Zui The Traveller", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), nameof(Zui.SetChatButtons), new() {
            { "Zui's Quests", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_NotCheckmarked", new() {
            { "Hi hii! Thanks for asking! Could you fetch me some plants, you can use this bag! Just fill it up with some different types of plants and I'll give you some stuff afterwards!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_NotCheckmarkedHardmode", new() {
            { "Hehe I'm gonna up the difficulty of these, I'm gonna need some bigger plants, so you'll need to fill up this bag! Thanks!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_1Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_16Complete", new() {
            { "Nice nice, I'll take these, could you fetch some more for me!  ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_3Complete", new() {
            { "Ok ok, 3 quests is kind of good, thanks for caring a lot about this! I've got more items in my shop for you, bring me 3 more and I'll get more for ya!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_6Complete", new() {
            { "6 Quests is actually kind of crazy, I've opened up with a few more items for you if you want! Bring me 4 more ;p", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_10Complete", new() {
            { "Damn, 10 quests? You're on a role you know! I've got some more items for you in my shop actually, I went travelling and Sirestias gave me a few items! I'll give you some more items if you can do 10 more!", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_20Complete", new() {
            { "You have finished 20 quests for me! Thank you! I've got more items in my shop because of it too! If you want more from me bring me ten more and maybe we can have some fun! ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "Quest_30Complete", new() {
            { "My graditude is of the utmost thanks, in return you can have anything in my shop! And I'll help you out personally sometime if you need me ;p ", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(Zui), "StartQuests", new() {
            { "Hiya! I think that's all the things I need, you can get some stuff in my shop but thanks babe!", "填入汉化文本" },
        });
        #endregion

        #region ZuiDeath
        ForceLocalizeSystem.LocalizeByTypeName(nameof(ZuiDeath), nameof(ZuiDeath.AI), new() {
            { "I think I have a headache..", "填入汉化文本" },
            { "I'll see you later at my shop! Fun time :)", "填入汉化文本" },
        });
        #endregion
        #region EreshkigalIdle
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetBestiary), new() {
            { "A mystical veil user who took accountability to chain up Sigfried", "填入汉化文本" },
            { "Ereshkigal the Lover", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.GetChat), new() {
            { "Leave me and my husband alone", "填入汉化文本" },
            { "You should all be jealous that I'm here.", "填入汉化文本" },
            { "Welcome welcome! Come here to feast your eyes on us?", "填入汉化文本" },
            { "Oh dear Sigfried how we've met..", "填入汉化文本" },
            { "Come and go you will, you'll be broken more than the others.", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeInOrderByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetNPCNameList), new() {
            { "Ereshkigal the Lover", "填入汉化文本" },
            { "Ereshkigal the Lover", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.SetChatButtons), new() {
            { "Give her something.", "填入汉化文本" },
            { "Sigfried?", "填入汉化文本" },
        });
        ForceLocalizeSystem.LocalizeByTypeName(nameof(EreshkigalIdle), nameof(EreshkigalIdle.OnChatButtonClicked), new() {
            { "OMG, OMG OMG OMG OMG", "填入汉化文本" },
            { "What is this? Nothing of importance to me... You are worthless, you're life is as valuable as a cinderspark summer ant, you mean nothing. You should get me something good NOW. You should burn in the Cinderspark..", "填入汉化文本" },
            { "Oh what a darling he is. Too bad I'm tasked with keeping him here forever right? He can't escape me :3 ", "填入汉化文本" },
            { "Sigfried is my husband you know. We met on the sacred lands of the Illuria, I may have been kicked out numerous times to talk to my king but I'd do anything to get with him", "填入汉化文本" },
            { "He's so pure, going for such high level threats such as Lumi and stealing her singularity. That's the type of man I like, one who isn't afraid to get their hands dirty.", "填入汉化文本" },
            { "I wish we could stay together always.", "填入汉化文本" },
            { "Oh his dear Mordred, I bet he doesn't even know hit wife was trapped within a weapon :)", "填入汉化文本" },
            { "Stupid dragon always getting in the way to getting to my wonderous babe, I would trap it as well but then it'd anger my dearest here.", "填入汉化文本" },
            { "How many doors do I need to store Lumi? I don't really know but I don't care. As long as she doesn't come after my husband.", "填入汉化文本" },
        });
        #endregion
    }
}