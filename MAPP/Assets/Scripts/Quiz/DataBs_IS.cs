using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_IS : MonoBehaviour
{
    private List<Question> questions;
    private void Awake()
    {
        questions = new List<Question>();
    }
    void addQuest(Answer a1, Answer a2, Answer a3, string s)
    {
        List<Answer> answers = new List<Answer>();
        answers.Add(a1); answers.Add(a2); answers.Add(a3);
        questions.Add(new Question(s, answers));
    }

    void dataBs()
    {
        addQuest(new Answer("G�teborg", false, -1), new Answer("Malm�", false, 0), new Answer("Stockholm", true, 1), "Vilken �r Sveriges huvudstad?");
        addQuest(new Answer("40 ", false, -1), new Answer("62 ", false, 0), new Answer("50", true, 1), "Hur m�nga delstater har USA?");
        addQuest(new Answer("Tokyo", true, -1), new Answer("Kyoto", false, 0), new Answer("Osaka", false, 1), "Japans huvudstad?");
        addQuest(new Answer("Oslo", true, -1), new Answer("Bergen", false, 0), new Answer("Trondheim", false, 1), "Norges huvudstad?");
        addQuest(new Answer("USA", false, -1), new Answer("Australien", false, 0), new Answer("Ryssland", true, 1), "V�rldens st�rsta land till ytan �r ...");
        addQuest(new Answer("Danmark", true, -1), new Answer("Island", false, 0), new Answer("Sverige", false, 1), "Gr�nland �r inget eget land utan h�r till?");
        addQuest(new Answer("Brasilia", true, -1), new Answer("Rio de Janeiro", false, 0), new Answer("Sao Paulo", false, 1), "Vilken �r Brasiliens huvudstad?");
        addQuest(new Answer("Sverige ", false, -1), new Answer("Island ", true, 0), new Answer("Norge", false, 1), "Vilket land tillh�r INTE Skandinavien?");
        addQuest(new Answer("Napoleon I", false, -1), new Answer("Julius Caesar", true, 0), new Answer("Karl den Store", false, 1), "Vem av dessa personer var en Romersk kejsare");
        addQuest(new Answer("1952", false, -1), new Answer("1948", false, 0), new Answer("1944", true, 1), "Vilket �r m�rdades Indiska politikern Mahatma Gandhi");
        addQuest(new Answer("1985 ", false, -1), new Answer("1989 ", true, 0), new Answer("1991", false, 1), "Vilket �r revs Berlinmuren ner?");
        addQuest(new Answer("1453 ", true, -1), new Answer("1429 ", false, 0), new Answer("1398", false, 1), "Vilket �r f�ll Konstantinopel?");
        addQuest(new Answer("1531-1558", false, -1), new Answer("1523-1560", true, 0), new Answer("1508-1539", false, 1), "Vilka �r var Gustav Vasa Kung av Sverige");
        addQuest(new Answer("1792 ", true, -1), new Answer("1784 ", false, 0), new Answer("1796", false, 1), "Vilket �r dog Gustav III, efter blivit attackerad p� en maskeradbal");
        addQuest(new Answer("Kolmonoxid", true, -1), new Answer("Koldioxid", false, 0), new Answer("Svaveltrioxid", false, 1), "Vad �r korrekt namn f�r CO?");
        addQuest(new Answer("V�gl�ngd", true, -1), new Answer("V�gresa", false, 0), new Answer("kraftl�ngd", false, 1), "Avst�ndet mellan tv� v�gtoppar (v�gdalar), kallas f�r...?");
        addQuest(new Answer("G�r ", false, -1), new Answer("H�st ", false, 0), new Answer("Stor", true, 1), "Vad �r ett exempel p� ett adjektiv?");
        addQuest(new Answer("St�rst ", true, -1), new Answer("Storast ", false, 0), new Answer("Storar", false, 1), "Stor, st�rre ...?");
        addQuest(new Answer("9 ", true, -1), new Answer("10 ", false, 0), new Answer("6", false, 1), "Hur m�nga ordklasser finns det?");
        addQuest(new Answer("Enouf ", false, -1), new Answer("Enough ", true, 0), new Answer("Enogh", false, 1), "Hur s�ger du nog p� engelska?");

        // addQuest(new Answer("1518 ", false, -1), new Answer("1520 ", false, 0), new Answer("1521", true, 1), "Vilket �r �gde Stockholms blodbad rum?");
        //addQuest(new Answer("1498 ", false, -1), new Answer("1516 ", false, 0), new Answer("1492", true, 1), "Vilket �r n�dde Christofer Columbus Amerika?");

    }
    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
