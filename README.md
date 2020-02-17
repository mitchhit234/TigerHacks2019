# TigerHacks2019

## Devpost Link
  - https://devpost.com/software/double-cross

## Theme: Art

## Title: Double-Cross
#### Several roles in the game:
  - Double-Agent: Pick a hard code word to throw off detectives, also throw off detectives during guessing phase
  - Witness: Knows the code word, tries to get detectives to say it
  - Detectives: try guessing the code word input by the double-agent
    
#### Procedure:
 1. Everyone receives text prompt from twilio to send in their code word
 2. Everyone receives text indicating whether they are the double-agent or a detective
 3.  Witness is called by twilo, voice message tells him he is the witness and gives him the word from double-agent
 Call audio: ""
 4. Witness has 3 rounds to get detectives to say the word in an allotted amount of time
  - Charades
  - Drawing
  - Describing
 5. Detectives get one collective guess as to who the double-agent is in order to win the game.
 
#### Languages
 - [x] HTML5
 - [x] CSS
 - [x] C#
 - [x] Twilio

#### Coding Necessities: 
 - [x] Drawing interface
 - [x] Input for name & Number
 - [x] Countdown timer
