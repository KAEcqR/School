#include <iostream> string

using namespace std;

struct Data {
    int dd, mm, rr;
};

class SmartPhone {
    string Marka;
    string Model;
    int64_t Imei;
    Data DataProdukcji;

public:
    SmartPhone() {
        Marka = "Phone";
        Model = "MyPhone";
        Imei = 111112222233333;
        DataProdukcji = { 1,1,2022 };
    }

    SmartPhone(string marka, string model, long imei) {
        Marka = marka;
        Model = model;
        Imei = imei;
    }

    SmartPhone(const string marka, const string model, int64_t imei, const Data dataProdukcji)
        : Marka(marka), Model(model), Imei(imei), DataProdukcji(dataProdukcji) {}

    void zadzwon() {
        cout << "Telefon dzwoni" << endl;
    }
    
    void zrobZdjecie() {
        cout << "Telefon zrobil zdjecie" << endl;
    }

    void info() {
        cout << "Marka: " << Marka << " Model: " << Model << " imei: " << Imei << " DataProdukcji: " << DataProdukcji.dd << DataProdukcji.mm << DataProdukcji.rr << endl;
    }
};

int main()
{
    SmartPhone phone1;
    phone1.info();
    phone1.zadzwon();
}

