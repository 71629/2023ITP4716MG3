using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreDisplay;
    [SerializeField] public int Aerobatics = 0;
    [SerializeField] GameObject Hit1, Hit2, Hit3, Hit4, Hit5, Hit6, Hit7, Hit8, Hit9, Hit10, Hit11, Hit12, Hit13, Hit14, Hit15, Hit16, Hit17, Hit18, Hit19, Hit20, Hit21, Hit22, Hit23, Hit24, Hit25, Hit26, Hit27, Hit28, Hit29, Hit30, Hit31, Hit32, Hit33, Hit34, Hit35, Hit36, Hit37, Hit38, Hit39, Hit40, Hit41, Hit42, Hit43, Hit44, Hit45, Hit46, Hit47, Hit48, Hit49, Hit50, Hit51, Hit52, Hit53, Hit54, Hit55, Hit56, Hit57, Hit58, Hit59, Hit60, Hit61, Hit62, Hit63, Hit64, Hit65, Hit66, Hit67, Hit68, Hit69, Hit70, Hit71, Hit72, Hit73, Hit74, Hit75, Hit76, Hit77, Hit78, Hit79, Hit80, Hit81, Hit82, Hit83, Hit84, Hit85, Hit86, Hit87, Hit88, Hit89, Hit90, Hit91, Hit92, Hit93, Hit94, Hit95, Hit96, Hit97, Hit98, Hit99, Hit100, Hit101, Hit102, Hit103, Hit104, Hit105, Hit106, Hit107, Hit108, Hit109, Hit110, Hit111, Hit112, Hit113, Hit114, Hit115, Hit116, Hit117, Hit118, Hit119, Hit120, Hit121, Hit122, Hit123, Hit124, Hit125, Hit126, Hit127, Hit128, Hit129, Hit130, Hit131, Hit132, Hit133, Hit134, Hit135, Hit136, Hit137, Hit138, Hit139, Hit140;
    [SerializeField] bool CHit1, CHit2, CHit3, CHit4, CHit5, CHit6, CHit7, CHit8, CHit9, CHit10, CHit11, CHit12, CHit13, CHit14, CHit15, CHit16, CHit17, CHit18, CHit19, CHit20, CHit21, CHit22, CHit23, CHit24, CHit25, CHit26, CHit27, CHit28, CHit29, CHit30, CHit31, CHit32, CHit33, CHit34, CHit35, CHit36, CHit37, CHit38, CHit39, CHit40, CHit41, CHit42, CHit43, CHit44, CHit45, CHit46, CHit47, CHit48, CHit49, CHit50, CHit51, CHit52, CHit53, CHit54, CHit55, CHit56, CHit57, CHit58, CHit59, CHit60, CHit61, CHit62, CHit63, CHit64, CHit65, CHit66, CHit67, CHit68, CHit69, CHit70, CHit71, CHit72, CHit73, CHit74, CHit75, CHit76, CHit77, CHit78, CHit79, CHit80, CHit81, CHit82, CHit83, CHit84, CHit85, CHit86, CHit87, CHit88, CHit89, CHit90, CHit91, CHit92, CHit93, CHit94, CHit95, CHit96, CHit97, CHit98, CHit99, CHit100, CHit101, CHit102, CHit103, CHit104, CHit105, CHit106, CHit107, CHit108, CHit109, CHit110, CHit111, CHit112, CHit113, CHit114, CHit115, CHit116, CHit117, CHit118, CHit119, CHit120, CHit121, CHit122, CHit123, CHit124, CHit125, CHit126, CHit127, CHit128, CHit129, CHit130, CHit131, CHit132, CHit133, CHit134, CHit135, CHit136, CHit137, CHit138, CHit139, CHit140;

    // Start is called before the first frame update
    void Start()
    {
        CHit1 = false; CHit2 = false; CHit3 = false; CHit4 = false; CHit5 = false; CHit6 = false; CHit7 = false; CHit8 = false; CHit9 = false; CHit10 = false; CHit11 = false; CHit12 = false; CHit13 = false; CHit14 = false; CHit15 = false; CHit16 = false; CHit17 = false; CHit18 = false; CHit19 = false; CHit20 = false; CHit21 = false; CHit22 = false; CHit23 = false; CHit24 = false; CHit25 = false; CHit26 = false; CHit27 = false; CHit28 = false; CHit29 = false; CHit30 = false; CHit31 = false; CHit32 = false; CHit33 = false; CHit34 = false; CHit35 = false; CHit36 = false; CHit37 = false; CHit38 = false; CHit39 = false; CHit40 = false; CHit41 = false; CHit42 = false; CHit43 = false; CHit44 = false; CHit45 = false; CHit46 = false; CHit47 = false; CHit48 = false; CHit49 = false; CHit50 = false; CHit51 = false; CHit52 = false; CHit53 = false; CHit54 = false; CHit55 = false; CHit56 = false; CHit57 = false; CHit58 = false; CHit59 = false; CHit60 = false; CHit61 = false; CHit62 = false; CHit63 = false; CHit64 = false; CHit65 = false; CHit66 = false; CHit67 = false; CHit68 = false; CHit69 = false; CHit70 = false; CHit71 = false; CHit72 = false; CHit73 = false; CHit74 = false; CHit75 = false; CHit76 = false; CHit77 = false; CHit78 = false; CHit79 = false; CHit80 = false; CHit81 = false; CHit82 = false; CHit83 = false; CHit84 = false; CHit85 = false; CHit86 = false; CHit87 = false; CHit88 = false; CHit89 = false; CHit90 = false; CHit91 = false; CHit92 = false; CHit93 = false; CHit94 = false; CHit95 = false; CHit96 = false; CHit97 = false; CHit98 = false; CHit99 = false; CHit100 = false; CHit101 = false; CHit102 = false; CHit103 = false; CHit104 = false; CHit105 = false; CHit106 = false; CHit107 = false; CHit108 = false; CHit109 = false; CHit110 = false; CHit111 = false; CHit112 = false; CHit113 = false; CHit114 = false; CHit115 = false; CHit116 = false; CHit117 = false; CHit118 = false; CHit119 = false; CHit120 = false; CHit121 = false; CHit122 = false; CHit123 = false; CHit124 = false; CHit125 = false; CHit126 = false; CHit127 = false; CHit128 = false; CHit129 = false; CHit130 = false; CHit131 = false; CHit132 = false; CHit133 = false; CHit134 = false; CHit135 = false; CHit136 = false; CHit137 = false; CHit138 = false; CHit139 = false; CHit140 = false;
        Aerobatics = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = Aerobatics.ToString("f0");
        if (Hit1 == null && CHit1 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit1 = true;
        }
        if (Hit2 == null && CHit2 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit2 = true;
        }
        if (Hit3 == null && CHit3 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit3 = true;
        }
        if (Hit4 == null && CHit4 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit4 = true;
        }
        if (Hit5 == null && CHit5 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit5 = true;
        }
        if (Hit6 == null && CHit6 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit6 = true;
        }
        if (Hit7 == null && CHit7 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit7 = true;
        }
        if (Hit8 == null && CHit8 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit8 = true;
        }
        if (Hit9 == null && CHit9 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit9 = true;
        }
        if (Hit10 == null && CHit10 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit10 = true;
        }
        if (Hit11 == null && CHit11 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit11 = true;
        }
        if (Hit12 == null && CHit12 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit12 = true;
        }
        if (Hit13 == null && CHit13 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit13 = true;
        }
        if (Hit14 == null && CHit14 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit14 = true;
        }
        if (Hit15 == null && CHit15 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit15 = true;
        }
        if (Hit16 == null && CHit16 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit16 = true;
        }
        if (Hit17 == null && CHit17 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit17 = true;
        }
        if (Hit18 == null && CHit18 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit18 = true;
        }
        if (Hit19 == null && CHit19 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit19 = true;
        }
        if (Hit20 == null && CHit20 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit20 = true;
        }
        if (Hit21 == null && CHit21 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit21 = true;
        }
        if (Hit22 == null && CHit22 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit22 = true;
        }
        if (Hit23 == null && CHit23 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit23 = true;
        }
        if (Hit24 == null && CHit24 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit24 = true;
        }
        if (Hit25 == null && CHit25 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit25 = true;
        }
        if (Hit26 == null && CHit26 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit26 = true;
        }
        if (Hit27 == null && CHit27 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit27 = true;
        }
        if (Hit28 == null && CHit28 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit28 = true;
        }
        if (Hit29 == null && CHit29 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit29 = true;
        }
        if (Hit30 == null && CHit30 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit30 = true;
        }
        if (Hit31 == null && CHit31 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit31 = true;
        }
        if (Hit32 == null && CHit32 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit32 = true;
        }
        if (Hit33 == null && CHit33 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit33 = true;
        }
        if (Hit34 == null && CHit34 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit34 = true;
        }
        if (Hit35 == null && CHit35 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit35 = true;
        }
        if (Hit36 == null && CHit36 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit36 = true;
        }
        if (Hit37 == null && CHit37 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit37 = true;
        }
        if (Hit38 == null && CHit38 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit38 = true;
        }
        if (Hit39 == null && CHit39 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit39 = true;
        }
        if (Hit40 == null && CHit40 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit40 = true;
        }
        if (Hit41 == null && CHit41 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit41 = true;
        }
        if (Hit42 == null && CHit42 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit42 = true;
        }
        if (Hit43 == null && CHit43 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit43 = true;
        }
        if (Hit44 == null && CHit44 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit44 = true;
        }
        if (Hit45 == null && CHit45 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit45 = true;
        }
        if (Hit46 == null && CHit46 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit46 = true;
        }
        if (Hit47 == null && CHit47 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit47 = true;
        }
        if (Hit48 == null && CHit48 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit48 = true;
        }
        if (Hit49 == null && CHit49 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit49 = true;
        }
        if (Hit50 == null && CHit50 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit50 = true;
        }
        if (Hit51 == null && CHit51 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit51 = true;
        }
        if (Hit52 == null && CHit52 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit52 = true;
        }
        if (Hit53 == null && CHit53 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit53 = true;
        }
        if (Hit54 == null && CHit54 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit54 = true;
        }
        if (Hit55 == null && CHit55 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit55 = true;
        }
        if (Hit56 == null && CHit56 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit56 = true;
        }
        if (Hit57 == null && CHit57 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit57 = true;
        }
        if (Hit58 == null && CHit58 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit58 = true;
        }
        if (Hit59 == null && CHit59 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit59 = true;
        }
        if (Hit60 == null && CHit60 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit60 = true;
        }
        if (Hit61 == null && CHit61 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit61 = true;
        }
        if (Hit62 == null && CHit62 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit62 = true;
        }
        if (Hit63 == null && CHit63 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit63 = true;
        }
        if (Hit64 == null && CHit64 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit64 = true;
        }
        if (Hit65 == null && CHit65 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit65 = true;
        }
        if (Hit66 == null && CHit66 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit66 = true;
        }
        if (Hit67 == null && CHit67 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit67 = true;
        }
        if (Hit68 == null && CHit68 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit68 = true;
        }
        if (Hit69 == null && CHit69 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit69 = true;
        }
        if (Hit70 == null && CHit70 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit70 = true;
        }
        if (Hit71 == null && CHit71 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit71 = true;
        }
        if (Hit72 == null && CHit72 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit72 = true;
        }
        if (Hit73 == null && CHit73 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit73 = true;
        }
        if (Hit74 == null && CHit74 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit74 = true;
        }
        if (Hit75 == null && CHit75 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit75 = true;
        }
        if (Hit76 == null && CHit76 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit76 = true;
        }
        if (Hit77 == null && CHit77 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit77 = true;
        }
        if (Hit78 == null && CHit78 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit78 = true;
        }
        if (Hit79 == null && CHit79 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit79 = true;
        }
        if (Hit80 == null && CHit80 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit80 = true;
        }
        if (Hit81 == null && CHit81 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit81 = true;
        }
        if (Hit82 == null && CHit82 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit82 = true;
        }
        if (Hit83 == null && CHit83 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit83 = true;
        }
        if (Hit84 == null && CHit84 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit84 = true;
        }
        if (Hit85 == null && CHit85 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit85 = true;
        }
        if (Hit86 == null && CHit86 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit86 = true;
        }
        if (Hit87 == null && CHit87 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit87 = true;
        }
        if (Hit88 == null && CHit88 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit88 = true;
        }
        if (Hit89 == null && CHit89 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit89 = true;
        }
        if (Hit90 == null && CHit90 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit90 = true;
        }
        if (Hit91 == null && CHit91 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit91 = true;
        }
        if (Hit92 == null && CHit92 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit92 = true;
        }
        if (Hit93 == null && CHit93 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit93 = true;
        }
        if (Hit94 == null && CHit94 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit94 = true;
        }
        if (Hit95 == null && CHit95 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit95 = true;
        }
        if (Hit96 == null && CHit96 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit96 = true;
        }
        if (Hit97 == null && CHit97 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit97 = true;
        }
        if (Hit98 == null && CHit98 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit98 = true;
        }
        if (Hit99 == null && CHit99 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit99 = true;
        }
        if (Hit100 == null && CHit100 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit100 = true;
        }
        if (Hit101 == null && CHit101 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit101 = true;
        }
        if (Hit102 == null && CHit102 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit102 = true;
        }
        if (Hit103 == null && CHit103 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit103 = true;
        }
        if (Hit104 == null && CHit104 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit104 = true;
        }
        if (Hit105 == null && CHit105 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit105 = true;
        }
        if (Hit106 == null && CHit106 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit106 = true;
        }
        if (Hit107 == null && CHit107 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit107 = true;
        }
        if (Hit108 == null && CHit108 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit108 = true;
        }
        if (Hit109 == null && CHit109 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit109 = true;
        }
        if (Hit110 == null && CHit110 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit110 = true;
        }
        if (Hit111 == null && CHit111 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit111 = true;
        }
        if (Hit112 == null && CHit112 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit112 = true;
        }
        if (Hit113 == null && CHit113 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit113 = true;
        }
        if (Hit114 == null && CHit114 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit114 = true;
        }
        if (Hit115 == null && CHit115 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit115 = true;
        }
        if (Hit116 == null && CHit116 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit116 = true;
        }
        if (Hit117 == null && CHit117 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit117 = true;
        }
        if (Hit118 == null && CHit118 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit118 = true;
        }
        if (Hit119 == null && CHit119 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit119 = true;
        }
        if (Hit120 == null && CHit120 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit120 = true;
        }
        if (Hit121 == null && CHit121 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit121 = true;
        }
        if (Hit122 == null && CHit122 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit122 = true;
        }
        if (Hit123 == null && CHit123 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit123 = true;
        }
        if (Hit124 == null && CHit124 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit124 = true;
        }
        if (Hit125 == null && CHit125 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit125 = true;
        }
        if (Hit126 == null && CHit126 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit126 = true;
        }
        if (Hit127 == null && CHit127 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit127 = true;
        }
        if (Hit128 == null && CHit128 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit128 = true;
        }
        if (Hit129 == null && CHit129 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit129 = true;
        }
        if (Hit130 == null && CHit130 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit130 = true;
        }
        if (Hit130 == null && CHit130 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit130 = true;
        }
        if (Hit131 == null && CHit131 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit131 = true;
        }
        if (Hit132 == null && CHit132 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit132 = true;
        }
        if (Hit133 == null && CHit133 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit133 = true;
        }
        if (Hit134 == null && CHit134 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit134 = true;
        }
        if (Hit135 == null && CHit135 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit135 = true;
        }
        if (Hit136 == null && CHit136 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit136 = true;
        }
        if (Hit137 == null && CHit137 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit137 = true;
        }
        if (Hit138 == null && CHit138 == false)
        {
            Aerobatics = Aerobatics + 500;
            CHit138 = true;
        }
    }
}
