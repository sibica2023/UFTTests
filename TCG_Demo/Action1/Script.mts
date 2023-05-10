Browser("Advantage Shopping").Page("Advantage Shopping").Link("CONTACT US").Click @@ script infofile_;_ZIP::ssf1.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebList("categoryListboxContactUs").Select DataTable("categoryListboxContactUs_Item", dtGlobalSheet) @@ script infofile_;_ZIP::ssf2.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebList("productListboxContactUs").Select DataTable("productListboxContactUs_Item", dtGlobalSheet) @@ script infofile_;_ZIP::ssf3.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("emailContactUs").Set DataTable("emailContactUs_Text", dtGlobalSheet) @@ script infofile_;_ZIP::ssf4.xml_;_
