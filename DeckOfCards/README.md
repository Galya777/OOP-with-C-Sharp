Sofia University
Department of Mathematics and Informatics
Course : OO Programming with C#.NET
Date: October 15, 2012
Student Name:
Lab No. 3b
Submit the all C#.NET files developed to solve the problems listed below. Use comments and
Modified-Hungarian notation.
Problem No. 1
Дадени са 52 карти с:
a) сила (faces) – “Ace”, “Deuce”, “Three”, “Four”, “Five”, “Six”,
“Seven”, “Eight”, “Nine”, “Ten”, “Jack”, “Queen”, “King”
b) цвят (suit)- “Hearts”, “Diamonds”, “Clubs” и ” “Spades”
Модифицирайте приложението от Fig. 8.9- 10 (приложен към заданието с файл
SampleCodeFig8.rar ) даден в лекция 4, така че да раздава по 5 карти при игра
на покер.
Модифицирайте също class DeckOfCards от Fig. 8.10 да включва методи за
определяне дали петте карти от едно раздаване съдържат
a) чифт (2 карти с еднаква сила)
b) два чифта
c) терца (например, три Аса)
d) четири карти с еднаква сила (например, четири Аса)
e) пет карти от една боя
f) последователност (т.е., пет карти с поредни стойсности на сила)
g) “пълна къща” (т.е., две карти от една боя и три карти от друга боя)
[Препоръка: Добавете методи getFace и getSuit към class Card даден на Fig.
8.9., а също и метод private int[] totalHand( Card hand[] ) към class
DeckOfCards който връща масив от 13 елемента, всеки които е броя на картите със
съответна сила в дадено раздаване Card hand[]- например, първият елемент на този
масив ще дава броя на асата в раздаването, десетият елемент ще е броят на
десетките в в раздаването и т.н. Посредством totalHand() лесно може да се
отговори на всеки от въпросите a- g ]
Напишете конзолно приложение за тестване н аметодите ( a – g)
