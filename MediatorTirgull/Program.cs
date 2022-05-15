using MediatorTirgull;
FacebookGroupcs gruop1 = new FacebookGroupcs();
Member m1 = new Member(gruop1, "Haim");
Member m2 = new Member(gruop1, "Tal");
Member m3 = new Member(gruop1, "Gal");
gruop1.AddMember(m1);
gruop1.AddMember(m2);
gruop1.AddMember(m3);
m1.Publish("Hello");
m2.Publish("Hello you too");


