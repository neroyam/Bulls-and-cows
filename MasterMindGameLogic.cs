using System;
using System.Collections.Generic;

namespace MasterMindWin
{
	public class Result//�����, ����������� ��� ������� ������������� ������
    {
        public List<byte> Rows = new List<byte>() { 0, 0, 0, 0 };
    }
	public class Master //�����, ����������� ��������� ��������� ������������������, ������� ����� ���������� �����
	{
        public List<byte> Rows = new List<byte>() { 0, 0, 0, 0 };
		public void SetMaster(Pegs p)//��������� ����������, ������� ������ ������� ������������
		{
            List<byte> xs = new List<byte>();
            for (byte i = 1; i < p.Values.Count+1; i++)
                xs.Add(i);                        
            Random ks = new Random();
            byte js, ls,chek;
            chek = 0;

            for (int i=p.Values.Count-2;i>0;i--)
            {
                js = (byte)(ks.Next(1, xs.Count + 1-chek));
                ls = xs[i];
                xs[i] = xs[js-1];
                xs[js - 1] = ls;
                chek++;
            }
            js = 0;
            for (int i = 0; i < 4; i++)
            {
                Rows[i] = xs[xs.Count-1-js];
                js++;
            }
        }
    }
	public enum GameStatus //������������ �������� �������
	{
		Active = 1,
		Won    = 2,
		Lost   = 3
	}
    public class Pegs           //�����, � ������� ���������� ������������ �����
    {                           //�������� ����� ������ ������������
        public Pegs(byte Length)//��������� ���������� ����� 
        {                       //� �������� ����� �������� ��� ���
            Values = new List<byte>();
            for (byte i = 0; i < Length; i++)
            {
                byte k = i;
                k++;
                Values.Add(k);
            }
        }
        public List<byte> Values;
    }
	public class Board          //������������� �������� ���� � ���� ��������������� ���������
	{
        public List<List<byte>> Rowss = new List<List<byte>>()
        {
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
        };                      //��������� ������� �����, ��� ����� ��������� ����
        public List<List<byte>> Resultss = new List<List<byte>>()
        {
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
            new List<byte>() {0,0,0,0 },
        };                      //��������� �����, ���� ����� ������������ ��������� ����� ����
        public Board(byte b)    //�������� ���������� �����, � �������� ����� ������ ������������
		{                       //� ������� ���� � ����
			pegs = new Pegs(b);
			master.SetMaster(pegs);
		}
        public Board(int b, byte c) //�������� ���������� ����� � ���������� ����� 
        {                           //� �������� ����� ������ ������������, ����� ������� ������� ����
            pegs = new Pegs(c);
            master.SetMaster(pegs);
            if (b > Rowss.Count)
            {
                for (int i = Rowss.Count; i < b; i++)
                {
                    Rowss.Add(new List<byte>() { 0, 0, 0, 0 });
                    Resultss.Add(new List<byte>() { 0, 0, 0, 0 });
                }
            }
            else
            {
                Rowss.RemoveRange(b-1, Rowss.Count-b);
                Resultss.RemoveRange(b-1, Rowss.Count-b);
            }
        }

        public Master master = new Master();        
		public Pegs pegs;        
		public byte SelectedPeg = 255;        
		public GameStatus Status = GameStatus.Active;        
		private byte _ActiveRowNo =0;                
		public void test(int mychois)   //�������� �� ������������ ���������� �����������
        {                               //���������� � ��������� �������������
			if (ActiveRowIsComplite)
			{
                Result rs = CheckActiveRow();
                Resultss[_ActiveRowNo] = rs.Rows;                
                if (_ActiveRowNo < mychois - 1)
                {
                    if (rs.Rows[0] != 1 || rs.Rows[1] != 1 || rs.Rows[2] != 1 || rs.Rows[3] != 1)                    
                        _ActiveRowNo += 1;                    
                }
                else
                    Status = GameStatus.Lost;
                //���������, ���� ������������ �������, �� ������ ����������
                if (rs.Rows[0] == 1 && rs.Rows[1] == 1 && rs.Rows[2] == 1 && rs.Rows[3] == 1)
                    Status = GameStatus.Won;
            }
        }

		public byte ActiveRowNo     //�������� ��� ��������� ���������� �����, 
        {                           //� ������� ��� ���������� �����
            get {return _ActiveRowNo;}
		}
		public void StartNew(int mychois)           //����������� ��� ����������� ������ ���
        {                                           //������ ����� ����
			master.SetMaster(pegs);                 //����� ���������� �����   
            for (int i = 0; i < mychois; i++)       //��������� �������� ����
            {
                for (int j = 0; j < 4; j++)
                {
                    Rowss[i][j] = 0;
                    Resultss[i][j] = 0;
                }
            }
            Status = GameStatus.Active;             //����� ������� ����
			_ActiveRowNo = 0;
		}
		public void EndGame()                       //��������� ����
		{
			Status = GameStatus.Lost;
		}
		public bool ActiveRowIsComplite             //�������� �� ����������� ������
		{
			get
			{
				bool flag = true;
				for (int i=0;i<4;i++)
				{
                    if (Rowss[_ActiveRowNo][i] == 0)
                    {
                        flag = false;
                    }

                }
                return flag;
			}
		}
		public Result CheckActiveRow()      //�������� ���������� ���������� �� ������������
		{
			 
			byte fullmatchs = 0;            //���������� ��� ������������� "������� ���������" 
			byte crossmatchs = 0;           //��������� ��� ������������� ��������� �� �����
            Result rs = new Result();
            List<byte> flagsMasters = new List<byte>() { 0, 0, 0, 0 };
            List<byte> flagsRows= new List<byte>() { 0, 0, 0, 0 };
            for (int i = 0; i < 4; i++)
            {
                if (master.Rows[i] == Rowss[_ActiveRowNo][i])
                {
                    fullmatchs++;
                    flagsMasters[i] = 1;
                    flagsRows[i] = 1;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i != j) && (flagsMasters[i] != 1) && (flagsRows[j] != 1))
                    {
                        if (master.Rows[i] == Rowss[_ActiveRowNo][j])
                        {
                            crossmatchs++;
                            flagsMasters[i] = 1;
                            flagsRows[j] = 1;
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < fullmatchs; i++)
                rs.Rows[i] = 1;
            for (int i = fullmatchs; i < fullmatchs + crossmatchs; i++)
                rs.Rows[i] = 2;
            return rs;
		}
	}
}
