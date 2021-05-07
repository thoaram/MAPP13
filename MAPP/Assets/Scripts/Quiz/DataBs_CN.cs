using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBs_CN : MonoBehaviour
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
        addQuest(new Answer("��±�", false, -1), new Answer("���Ĭ", false, 0), new Answer("˹�¸��Ħ", true, 1), "�����׶��ǣ�");

        addQuest(new Answer("40", false, -1), new Answer("62", false, 0), new Answer("50", true, 1), "�����ж��ٸ�������?");

        addQuest(new Answer("����", true, -1), new Answer("����", false, 0), new Answer("���", false, 1), "�ձ����׶���");

        addQuest(new Answer("��˹½", true, -1), new Answer("������", false, 0), new Answer("��¡��ķ", false, 1), "Ų�����׶���");

        addQuest(new Answer("����˹", true, -1), new Answer("����", false, 0), new Answer("�Ĵ�����", false, 1), "����������������Ĺ�����?");

        addQuest(new Answer("��������� ", true, -1), new Answer("����������ɽ", false, 0), new Answer("�Ǹ����", false, 1), "��������ߵ�ɽ�ǣ�");

        addQuest(new Answer("�Ŷ��Ӻ�", true, -1), new Answer("��觺�", false, 0), new Answer("��������", false, 1), "ŷ����ĺ����ǣ�");


        addQuest(new Answer("����������ɽ", false, -1), new Answer("�Ǹ����", true, 0), new Answer("��³��", false, 1), "�����ϵڶ��ߵ�ɽ�ǣ�");


        addQuest(new Answer("����", false, -1), new Answer("����", true, 0), new Answer("���", false, 1), "�������������ĸ����ң�");

        addQuest(new Answer("�ϼ�", false, -1), new Answer("����", true, 0), new Answer("������", false, 1), "������λ�����");

        addQuest(new Answer("����", false, -1), new Answer("������", false, 0), new Answer("�ϼ�", true, 1), "�ϼ���λ�ڵ�������");

        addQuest(new Answer("ī����", false, -1), new Answer("������", true, 0), new Answer("Ϥ��", false, 1), "�Ĵ����ǵ��׶��ǣ�");


        addQuest(new Answer("Ī˹��", true, -1), new Answer("ʥ�˵ñ�", false, 0), new Answer("��ɽ", false, 1), "����˹���׶������");

        addQuest(new Answer("49", true, -1), new Answer("72", false, 0), new Answer("38", false, 1), "ŷ���ж��ٹ��ң�");

        addQuest(new Answer("5", false, -1), new Answer("7", true, 0), new Answer("10", false, 1), "�����м������ޣ�");

        addQuest(new Answer("����ѷ��", true, -1), new Answer("���޺�", false, 0), new Answer("�ع���", false, 1), "������ĺ����ǣ�");

        addQuest(new Answer("����ѷ��", false, -1), new Answer("�ع���", false, 0), new Answer("���޺�", true, 1), "�ڶ����ĺ����ǣ�");

        addQuest(new Answer("Ħ���", false, -1), new Answer("�����", false, 0), new Answer("��ٸ�", true, 1), "��������С�Ĺ����ǣ�");

        addQuest(new Answer("����", true, -1), new Answer("��Լ����¬", false, 0), new Answer("ʥ����", false, 1), "�������ǵ��׶��ǣ�");

        addQuest(new Answer("����", true, -1), new Answer("�ռ�", false, 0), new Answer("������", false, 1), "̩�����׶��ǣ�");

        addQuest(new Answer("������", false, -1), new Answer("̫ƽ�����", true, 0), new Answer("ӡ����", false, 1), "�������ĺ����ǣ�");

        addQuest(new Answer("����", false, -1), new Answer("����˹", false, 0), new Answer("�й�", true, 1), "�����ĸ������˿���ࣿ");

        addQuest(new Answer("����", true, -1), new Answer("���", false, 0), new Answer("Ų��", true, 1), "�����ĸ����Ҳ�����˹������ά��");

        addQuest(new Answer("����", true, -1), new Answer("����˹", false, 0), new Answer("����", false, 1), "�����ĸ��������ڱ�ŷ���ң�");

        //�����ǵ�������24��

        addQuest(new Answer("������һ��", false, -1), new Answer("�������", true, 0), new Answer("���������", false, 1), "����˭������ʵۣ�");

        addQuest(new Answer("�ɼ�˼��", true, -1), new Answer("��������", false, 0), new Answer("����ɽ���", false, 1), "˭���Ž��ɹŲ�����ɹ�ͳ���ߣ�");

        addQuest(new Answer("Ų��", true, -1), new Answer("����", false, 0), new Answer("����˹", false, 1), "����ʮ���������ĸ����ң�1718�꣩");

        addQuest(new Answer("1944", true, -1), new Answer("1948", false, 0), new Answer("1952", false, 1), "ӡ�����͸ʵ�����һ��������");

        addQuest(new Answer("26", false, -1), new Answer("19", true, 0), new Answer("23", false, 1), "����ʥŮ���ݴ���˱������ڻ������ϵ�ʱ������ꣿ");

        addQuest(new Answer("1949", false, -1), new Answer("1954", false, 0), new Answer("1961", true, 1), "����ǽ�ڼ����꽨�ɣ�");

        addQuest(new Answer("1985", false, -1), new Answer("1991", false, 0), new Answer("1989", true, 1), "����ǽ����һ���ģ�");

        addQuest(new Answer("�����", true, -1), new Answer("����۹�", false, 0), new Answer("����", false, 1), "����ɽ������ͳ�ι��ĸ����ң�");

        addQuest(new Answer("900���", true, -1), new Answer("700���", false, 0), new Answer("1000���", false, 1), "�������������ĸ�ʱ�ڵĻʵۣ�");

        addQuest(new Answer("1429", false, -1), new Answer("1398", false, 0), new Answer("1453", true, 1), "��ʿ̹��������һ�����ݣ�");

        addQuest(new Answer("1618-1648", true, -1), new Answer("1534-1564", false, 0), new Answer("1556-1586", false, 1), "��ʮ��ս���������ļ��ꣿ");

        addQuest(new Answer("1523-1560", true, -1), new Answer("1508-1539", false, 0), new Answer("1531-1558", false, 1), "�����ĸ�����������˹������������λʱ�䣿");

        addQuest(new Answer("�¹�", false, -1), new Answer("����", true, 0), new Answer("Ӣ��", false, 1), "������������ĸ����ҵģ�");

        addQuest(new Answer("1518", false, -1), new Answer("1520", true, 0), new Answer("1521", false, 1), "˹�¸��Ħ����ɱ��������һ����");

        addQuest(new Answer("1792", true, -1), new Answer("1784", false, 0), new Answer("1796", false, 1), "��˹���������ڻ�ױ��ᱻ�̺���������һ�ꣿ");

        addQuest(new Answer("1498", false, -1), new Answer("1516", false, 0), new Answer("1492", true, 1), "����˹�и����ײ���һ�������������");

        //��ʶ��16��

        addQuest(new Answer("1 000 000", true, -1), new Answer("10 000 000", false, 0), new Answer("100 000", false, 1), "һ�׺��ȵ��ڶ��ٺ��ȣ�");

        addQuest(new Answer("1,0 kg/dm3", true, -1), new Answer(" 1,5 kg/m3 ", false, 0), new Answer("1,0 kg/m3", false, 1), "ˮ���ܶ��Ƕ��٣�");

        addQuest(new Answer("36 kg/dm3  ", false, -1), new Answer("9 kg /dm3 ", true, 0), new Answer("16 kg/m3  ", false, 1), "һ��ͭ��18������Ϊ2 dm�����η����ܶ��Ƕ��٣�");
        

        addQuest(new Answer("19.8", false, -1), new Answer("9.8", true, 0), new Answer("9.88", false, 1), "��������е�������������䡣 ����Ħ�������䣬����ζ�ż��ٶ��Ǻ㶨�ġ� �ڵ��򸽽������Ϊ�������ٶȣ���Լ�Ƕ��٣� m / s2��");

        addQuest(new Answer("��", false, -1), new Answer("����", true, 0), new Answer("���ܶ�", false, 1), "������һ�ֹ��̣���������ֱ�Ӵӹ�����ʽ��Ϊ������ʽ��");

        addQuest(new Answer("��", true, -1), new Answer("����", false, 0), new Answer("���ܶ�", false, 1), "���������ʴ��ž�״ֱ̬��ת��Ϊ������ʽ����û��ͨ���м���Һ����ʽ��");

        addQuest(new Answer("��ѧ��Դ", false, -1), new Answer("����", true, 0), new Answer("����", false, 1), "�����ʲô������");

        addQuest(new Answer("һ������", true, -1), new Answer("������̼", false, 0), new Answer("��������", false, 1), "N2O����ȷ�����ǣ�");

        addQuest(new Answer("H2O", false, -1), new Answer("N2O", false, 0), new Answer("O2", true, 1), "�����������岻���������壿");

        addQuest(new Answer("һ����̼", true, -1), new Answer("������̼", false, 0), new Answer("��������", false, 1), "CO����ȷ�����ǣ�");

        addQuest(new Answer("-1��", false, -1), new Answer("0��", true, 0), new Answer("100��", false, 1), "�����۵��ǣ�");

        addQuest(new Answer("55��", false, -1), new Answer("0��", false, 0), new Answer("100��", true, 1), "ˮ�ķе��ǣ�");

        addQuest(new Answer("", false, -1), new Answer("", true, 0), new Answer("", false, 1), "�ĸ��¶ȳ�Ϊ������㣿");

        addQuest(new Answer("-273.15��", true, -1), new Answer("274.15��", false, 0), new Answer("-274.15��", false, 1), "");

        addQuest(new Answer("2", false, -1), new Answer("1", true, 0), new Answer("1.5", false, 1), "һ�����Ƕ���ţ���ף�");

        addQuest(new Answer("����", true, -1), new Answer("����", false, 0), new Answer("����", false, 1), "��������֮��ľ����Ϊ��");

        addQuest(new Answer("ѹǿ�������������", false, -1), new Answer("ѹǿ�������������", true, 0), new Answer("������ѹǿ�������", false, 1), "�����ĸ���ʽ����ȷ�ģ�");

        addQuest(new Answer("1 N/m2", true, -1), new Answer("2 N/m2", false, 0), new Answer("1.5 N/m2", false, 1), "һ��˹�����ڣ�");

        addQuest(new Answer("1 Pa", true, -1), new Answer("1 N", false, 0), new Answer("1 J", false, 1), "ѹǿ�Ļ�����λ�ǣ�");

        addQuest(new Answer("����", false, -1), new Answer("����", true, 0), new Answer("����", false, 1), "��ѹ��λ");

        addQuest(new Answer("����", false, -1), new Answer("m/s", false, 0), new Answer("����", true, 1), "Ƶ�ʵĵ�λ�ǣ�");

        addQuest(new Answer("220V", false, -1), new Answer("240V", false, 0), new Answer("230V", true, 1), "��ͨ����Ĳ�����ѹ�ǣ�");

        addQuest(new Answer("����", false, -1), new Answer("����", false, 0), new Answer("ˮ��", true, 1), "��С������");

        addQuest(new Answer("����", false, -1), new Answer("ľ��", true, 0), new Answer("������", false, 1), "�������ǣ�");

        addQuest(new Answer("������", false, -1), new Answer("������", true, 0), new Answer("֯Ů��", false, 1), "����̫�������ǿ��Դ����ǿ���������ĺ���?");

        addQuest(new Answer("��ϵ", false, -1), new Answer("����", true, 0), new Answer("�����ը", false, 1), "����ϵͳ");


       // ����ѧ26��




    }
    public List<Question> allQues()
    {
        dataBs();
        return questions;
    }
}
