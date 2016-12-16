namespace Moneris
{
    using System;

    public class TestUSAACHCredit
    {
        public static void Main(string[] args)
        {
            string order_id = "Test" + DateTime.Now.ToString("yyyyMMddhhmmss");
            string store_id = "monusqa002";
            string api_token = "qatoken";
            string amount = "1.00";

            //ACHInfo Variables
            string sec = "ppd";
            string cust_first_name = "Christian";
            string cust_last_name = "M";
            string cust_address1 = "3300 Bloor St W";
            string cust_address2 = "4th floor west tower";
            string cust_city = "Toronto";
            string cust_state = "ON";
            string cust_zip = "M1M1M1";
            string routing_num = "490000018";
            string account_num = "222222";
            string check_num = "11";
            string account_type = "checking";
            string micr = "t071000013t742941347o129";
            string dl_num = "CO-12312312";
            string magstripe = "no";
            string image_front = "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";
            string image_back = "SUkqAGoAAAA/Pz8wPz8/Pz8/MD8/Pz8/Pz8/Pz80Pz8/MD8ATWFnVGVrLCBJbmMuAABNSUNSSW1hZ2UgUlMyMzIgKCBBMDRXNFc1KQAATUkxLjA3LjI0TQAAyAAAAAEAAADIAAAAAQAAABIA/gADAAEAAAAAAAAAAAEDAAEAAADgBAAAAQEDAAEAAAAjAgAAAwEDAAEAAAAEAAAABgEDAAEAAAAAAAAACgEDAAEAAAABAAAADgECABwAAAAIAAAADwECAA0AAAAkAAAAEAECABsAAAAyAAAAEQEEAAEAAABIAQAAEgEDAAEAAAABAAAAFgEDAAEAAAAjAgAAFwEEAAEAAAAIFgAAGgEFAAEAAABaAAAAGwEFAAEAAABiAAAAJQEEAAEAAAAAAAAAKAEDAAEAAAACAAAAMQECAAsAAABOAAAAAAAAACOB3BpLYGl/76/llBUUIj5HIj5nF4xmHllEBDAoKR4F8RGoeWQKMj5HzYpvN8t0woQwhOIaPeWRDN5wz Rzx5xwVVBCDQqYgUzMvkdhHfIjQWSblGRzNikcyOLGDiHcIFW5hCNnGRwbAY4QiOTc XRHFI5kfBDJ CEMEXQkfN2 IIE62YBlN4jk2LUXRuI5kcL8pysBc8 JpqmXBlRFHLc7MuTakcyOKRzN9yY/EUhxCBBhAgZHwhERILjkUctmFUtwJHMj5HMuzYhHxBAqRriIwQiCRcEiI0THOOdfQ7RpLe4xl2XRc8jiBoQzXoRE9m DI Rw1JcHXKnlcWMjhlhYJRyfcujeOJHjeRwbTeI V0ZHRHyOKR8jjBZTk4NB3BQQhAhL6jeEEbzDI4QEIkEaSzMlVkcyOZHF4nHQz1R0CwUQgiOiOBfCE7TSTIJlyI4L444g2J/MMjt7I4NRHMRJsh52aBlSh8hR4cEeIggQkdkeiIiJODm8BZ2KgRNZxyq4sp0DuCBCHLoxEdggcYZrObmE5Q5xyY4I ZH3xWUOwQWRwdPCUIREYccGhHSEjxHBdDjxERG4QQJFzI RwYcnYiMLgwQVxEa5HQiLKaNV1XH8jr/h7HZbv8JgiPj5HSv/H415HUL/I/9x P5H4Lfg/d NcL9QRH 3duo4RHUO 2qCU74Hhcdr5IHcN5mCERTsgHXhupFDf2Yc cORgwmba7CI6hDYmhhNNO717c8RphHHuT1zW8mxkGv8d6RwfDxmQF0TYYzwpHMjgSF737QRehUNCe4eJbpYHhrkdeu8r47maM/oS3T5QC5HBqLgeKRxRfoP7if5FHkfoUi3iNg0RBEcFIxDXRHQWhzcbXG8mOUOU5S6sSGhxSImwN8fj5HwQRHSLplXvNoyKSL58DwOB/8 bXEdeIjghEgeBgcuQv/wRxwRH/Bni45HQnqQPDRB5GnhEdB qHERyejP5vzHIK7nc64l8VHFlE8KrCwkHIPBxzNx 6k mJ0rsQgWg8RH6L MI0zecXwzDwcEvxGEaGIWoMJfGhX52LUMuIbgWThBBeGgwQ7hF Kid3sYiI9ByIOndhD86MREe4 i64/OxYyylaXBBD6/B8F8H8L7 /39/X6  jIrf5lXN/CL52SRizf/Gdp//b lLg9uO/2QxlApERiWse/02cf9STgiPaRHRwn3CCDSf9ghw0UGXzElDQRH7 R0iVv/UUigky8hdxC7/CCHCD71WkkPJD2E0LeTauLg3e4dBfv0qC587Rz8t1UzGRxSOiOGmtBjbfggtA6hQRpvwrZWMbLcPI4OXZgGmMhrkdY EP66pBEdMPvcrlZF8j5HDbQhAghx0luOuF8fGSPK9YHBgDxYNaS8X1r6o4oIx5kJCGAPAkI ca95peSeFvccjqhZSOZTZHyOB4Eh9iM7QRcGVgOsiPcIFiONhmydi4ZBjD4IuhnH3ggXv5mjeJISCI6fOwIDw22HoZ9iIjZHTBrDHDKw6Iib0ER1yDOuT9OSEcUaCqEdYRCiqHUhrrqYLYQfz D1DWjomEfyciOKrIO3P2GkR1kdev7kfI XrZom/8fXFNVqr4iO8QRTtpr 4MLhz9ab4ZJ4jiI05dcEXQcJAingh6 GhwoSXhxGr9WIkOGn FITskL88uPwwhF8vXXuLsR16B2GCGu2xvxlD9qyP/G6I6fadf6sIjr6WuN EXSfQ/Bvp197ymhHk2j8Ed6ERX/Ozhb DIYpE6F/hPROKRTy8FekJHYmkEGcZNiXLjI7/RKHws8Z6I R82MuMJ5NhozgNHw0E2QaaI63CcRDRY EC3luZ5vMRHAgjhr/CoOcIEFYVnnGHJDscZX8twIDw2v6VIjoIQ9VnvKnN8ErYldZiOi R8jgsFyLgyMofweMWjQgapJrcQys5XJ5wGuIiJDQq39BIuNAz1VbEjrHoyMgOC4YZBlHIPuqvC0Cb839N T4l zIUA8FoY1tvxHvH7OcHnZoGQG8F2t5e Qn18RRA8DEjRkdB8KELmPydwRdf8gsLjQ8LEEVYISPq8FOE0JnyGkuS7UMnaiF9MTosT6U22XB2 lUSL0hbsTdDzGfWqiMIjrzNIIjoTCP8Js88/tbJj5Mf985AeJhH 3uRR4hBBL9iE8fJTDCr/Dij4sPpw0Puw1DNfWwwgzsh/sVhYpzrj9NMQgwhH7BnZQngh DX/d9BL1 XX /Gr/sEXWFHaLrpfvgi63/hceMrjsyj1o7FBc7BOyuNrhJ15XMH2R0SXKuTsi2Qn5tm8xnP4yDO9E3ZW4kEmbd3I LyEHaa/mZfwRoyXyQZcggZy7/J8 M2NtB8w//bsqN1p54gRCj7TiF9Ho4eCBhVCJj570kH2FWqfc4H/C7GicZxwRhjROz7wTQa2wRHp8tBh0IjY5H1 C DP4ZyCUA8Vk7hng/UFfTiEGE7uZ0HmjCfsRs3mN MH8j KCI6QZ LwQR7CfzXQIIEIj0MYm7sWeHhnek9Dieo8j M7oECHa19A4QXVNmRQTDWxE/0f VQ9D2nGvETnIS0e3 mOSaMp bTSozxhazXDbIXG4hlDD6RWoYiokfHc5Ef6D4jph/jdcbDYIEKBYPbYiJDWaWO2dEJfBAq1j5g4l0aXl2Csp5XAzNslzI4pzOA1kcMkNnBYQIcXE lHzXEdEdFIsQgWbjz8j5gQvlwg9QRHxGzfnLYaW8UdQNl5H/E/6ikIMZfN5H2dJFrwxyjxI ovnMvnO1hrxvqiGSCgchpwQYghbNBoLb/uzGLwZIxPIRCBVm9SMQ202IiJuz8FvjjitoRxERER sjMLBF45qb8hJIRcjqjGflN5 6U5H40zcXzTI7WHELVqgwQj8Ivwb8I93CI6FILZo8IIY1cjqEI mqtmKKy4sU4aEREWE3GFZjN5jxI6e7EfqzThQnTOX8MPHQtBoRg6Dx6Edazr7diCBCOR9fBAiOvdNhBhCOsPBFPx/WtzHZ5Aor4JpuHER1 6sxnPrOJBEdBB2XHHfW8w6ER9gsfencMEzDxdimhEj4iIjvZHXqFCf8QRH8GCBgsmxYD044YIIcNoGmnbiIiZsKW5nGM4CvZkFjO0sXVQ9Z7iIjQIItygDw2Z1ByDYQZiJXhM3VERERi5CQccgRBPiGbcfOybT1l2/sk3KxycE8EgRrlja5eR6f2Mm4iwRCi8i0/05V5PpknGpk/xnDNGYZzI53oRw SBDghsjgy5HiOClzODNhAnYl42EI4QEDkJhnI3BhBmB4MMIMwC6F64RHRFEPaoOLQaFpx un qfDDCmh3e7 TqcuKLjNGTc1tFxk3LjNDlwW4TBvNGXbmuzR4KaHNbgpE5U81mvLjyuQOF iCQrrSbrem2u0n35CXSesf knXcMPH/p ZBQQjgYu/32/qxr6fevJzBv68L/2tOprLPj/7VgjJDI Rw2GwVrvlkYr32DQ9 P9Bmo/3zAn/H2R4HwS/30SlgiQwOEEcedl2fZe/fgiP9ewfr/ Hff1//rJ5vRdv/XneZEMjhYcSDUhFTj5l80/o034X91fgxMhfMf4n2/r8 f ap//X/1wzKerESGAN3rtbaf1/ ubwwRHjl/nv31////OX9r6//jjKs62 hSuCI/mBPYfW6/3Wu 2vq2u2v69hdtWwltpXr/aWdlWYWI0R1wRdGjI9RH19a7RB3fGxXHFfxXw4 P4uHHxUfFREfceIS7u8xBDrx57CTaH/a2ml1f9hb/bu7QYWGmZycGEBYIFW1r7MP3g3H8isGcwY4QhhAwhEQwhEQYQk8IiIiIiIiMy4FiGTKg1vEUnsRH7xERERJH7nM2cZHHXO iPi6l8ut/TXXI QuTpgiP926tke8cxmHfUHFfiZx7FGt0IkM6 P912EX Edv8IND9DQiQyTh0tC5f8FEJXQlIyPFwcjguXGOO7ZEvOgRZh3w/Mdfwjnu52LxQZHBiZzuIJOiPvI 5/Ns2YQZdUaaPAIj88VD/13rsO7tB0fDBdlw04Iu7oYVQnCha4j0IvVPrsa66fxEhnHJoO8YfsIFM7o3wQj4hWE//hxERG2QY2Y OhF7ESRJoGuHEWXIhjhWChEdEfoFEhMkbQ IiOqc6c8HHCE//T/hlVrEnzzJH5dKb7hF0 4n8UE7 9mO/JVkcM0JLqT6l0J7uzB9qGo4RT5HBZ 77N 7EJfVhCbBfLcbi5Pw/1MeXIaERDQkTA8CC31yOZHgTnfKaOu7hqD3IeMg1wSXNDjk4J1GHIQcREaoHwqERERkDDfURIdxE7sjq hZ24sQ8CJDAYt DGJDMHLEsIOMnsPs7KmR1qg7S OMr1t8isR1hEdGSVkMH1j ZFobDAOYjtSV8EXXzLgLkcNKKOxuPmFM748aNAkWynOOSHEi ypi397 FEg45Bh7joO9//TMhCI81vgswEX8lLGOFDm2cIjnrSLH/UV4WE4h39Bp 52WL8UWOHNZ7cER8eq9giP7eC6H9/SvhEdJkdYM762DpoRdRMZdR PHhEXVcL/BcNVQKwiP6Izu9B6nUJjhBF7saHRQ3Ia/hWZwk OXMcfJTGAMEfN6JNF3p4kgZs9uHaucze05ezFeSAzAj2TsXULg3mKDPFrr6CN5u1VP 7yPGAawxhBDCMJVI/0E8j6BQRHpVPt oTj/t9iDI4ai7HxiMFC4Qvgio/HFO0LQiIrIYwltPbCJ0Xg4jmfj/uwhEUEI/xL40IjtYMIRlNE0FmPP4IFkY6SxvDVsc34nXEYfl1/ERLo55D8qkbiOxpfsGTqxyPGNYREZsGgEJDBtWC9N4UvmKzGYXw/Mw1C4TQ7S0Y1uorsjsNkfiQezuIwege2xbDBcRDiMziJBubBXu8t4iIxILm4YL0IiLIpurjsX2gd/KZSzg4S3B//4 dln/vI/44Ij/6wUXyOnW/hwRH CI O9wXGTJ/Jxf6MPH8JBkfOyPwhGypM MIiWTNyTYNzUiP EvynmfmMvgubz7Lo3qSOTh/vHsYUMR7OZvbghafiT4uLZf3GrzOFeR8dxxT3r Z5RiHNPMYiOH7hlOV82sREzQTCf04rE4sp8IER8yODR/FhDm10InYuB//M4T cRpanFqdqIjgeCjjiF2hEUzGJ JZGAPAnYKdlhGb7SET0XhMGSAUi6L5cDxoO/wxNUY4TmzhGgaDecBcwCuXrwiOhHNs42hPRiBBx8g73BCQbmwvjmkdLStBl3uwTPYUNiIkQ3PnZYWkx9C4aERkIbiu/bTTiIrhbhhCPEjoRHnZab69 / F4Srl/K2RE4nyNRUCkMTcRJAOSDBAzzNDQkVyZy4IOQGg8SyhSu09Kr4YTTZ2CIspYd6I3elM6vk4aJY0Tzy/y5tUCBvS5evozOg3QboP3vfSS7rbSbS//pel/70  iP/zPp9Ku/bS3HQ/SV46S0yx/ 3dg/CX8V2lf/yKbGSBF1xq/1IYu /7IU2Wozsz/q613b/8MPnZe 6  u//JxLBZA/uXRodycOpdVv/wemR8gt4 6eQ m199fSDcGjoZB LkDI4dd vf8el5ie4OuJDFOBP XPa7dav7f8FfEgpnCPZfMfewX1b 6/62lfhHWFyXI9kdmMuHQI2k8Z7o3dA9JXtLv99JtbSiITMBE0NZhyx8FYiY 4biTYZnEXRcMrsL22F2/ zAsMEmwsyiOZ5w7UQ4nILm10LVluZZHBrjkGM3FJbFcVIMPeKYqKnYIZRDYyvP fmYloe0ECi5biIjhrsm5TnHERCeF7Cw/vCDCDC8I s9jfdvhBeIn8xhSuU5PlwPy H QSCQ5xyYHERBhCdMRETXEZaELWbuxYbdbici9XlcOMAhHA8FALriIiNCIitEOxxHL1diTsTeIw3zIbzmYzMDw3LouCEcMwuy IiP0LDN9U rno/oEb7N0Lc7JCI RwpcHI4HiEcQwcSOVH5HydBxE5m5x9XofFNRBCI2FNIUt3hiSLdTfikOIm43iJ9HqJBtHLXH0ODERvET3Yie4acgSDnHMuBgiP4SIPZRWeDcawiOs9nIo0jcuyBdua/RH5vSR/J2UWNJCKTDMaH NkdXGtNMxNH/URP5sPqGFtNUODSEYKEKsjHRuP5cuTtdCIi5H8FqXTPZssLdfERH8GpRGAieLQIEIiIp0F8kPERGD4iI1EPOwSXDBvj8IsoJ3BFNGQd4Ij4kf4qtBdNgnDUj9qLoOCwWR1ul3vt/ofO8Zm dqWRSWoIuoIE5oEU1u7/QoH8EXxI1mhHm/g5nLe1sM0jxnsuYJhPjwrEOMKCEINDDbO4eTYWzhEcMsH7CyolI6svHlKHOPDBEcw4SP W60MvkcMwKRyI4NN4OxM4 FrxZVxaEO9OJbiwZnITzxsjtkFA4QIF4LOo4IRrxPpAsWU3w8GvSkcCGLkxXXwcGCNqzDHP6iJvUriwNkhmuIiTs5mLXxL4IEMM3bQiJyOYkfBTJYZ7I R2Rw2jZniI7YkIzlWD xD4nInR7rQzJGYiOMuB4aYQLPRlj4KQTSJ6CbibODDKzoqVYiJA8C8ioNw53RyT9M5iDjesgeGFz93TWYxrbNoXcT7kFdcE9RUaf8p9JPMTIMN/Cwg1n GeSTsGJfeHmIJJiJH7p3DhcPDQnsL7H HvCu4VoGXBG/rJuohwmhEe1q/wwmE181ZmjHw wyURERFeg1C 7QiI4dfuIlkEvCI6cREUuI Dg8F79Efru3jHllKP CLpg966WC7yTKaWPeC R/Q9BvyylSHfghsPCIY iCCDNU0g5h/hCZ/7TPEftEihmxynaDTyc0MNC0WO8m5RkGZcKR0R/KIlEi3R9QgfJsZsjxHRHEMCGBSHEcG J09kdCIiE6cSbAsXIjg8w5Tplzm8uGcuMRxk/7k2qzYpsKCBIq0DJwEFBtljhGHoTjmaAu6JEOmW4Lm4wFI5ggQZrgj4Z2gbISBiCFLCERwSia5TEJbnEI4yOGgIR3sQahxZ2dS7J8zxEIiLgpY5Mc7jBnH4MEIiODfCCN5tgiMeVxAHhXgiOIYx1wxF2dcCIMo5CM0a6QRjd5DUZqwG4fiJ MbIrSThWkEJ/OI9tQx4STNwQUHHlkhGqL Ex3I3bXi HCYlOg21CH8JoRESyXnXznxEILusLHHDJtTEdFuLZzI R0XM4gQIdldLiPlwYMRiCcdjjyuJhCOGYRzMGIiLrcrnDWLsxiIjoyUs2GuYYcSo9mX5HDWI6BHHO5FHPZ7OVHCSP1OykFUj5pEcURsMEC0ImrNxdmOhGGjsMCc5AlQQKZ0cxCKiIl0aM/p7iNSsxcNQxF44y7I JfvL4whG0RXKHPYIREaCJfOmR8wRHBoJCCBCGIQlCxsSPggrI4QECGdpluZgoBAqTaP56NOxI YgRnmIjhMEKBAh5TUfMBy8R0InMHCCMbDhl8jhriIiIjhzDlDnsq2ECxBCIjkK1Q6pi8xWYBcj5vHdoRBiIjiJ2sLD//////9f////3/ABABAA==";
            string processing_country_code = "US";
            bool status_check = false;

            ACHInfo achinfo = new ACHInfo(sec, cust_first_name, cust_last_name,
                cust_address1, cust_address2, cust_city, cust_state, cust_zip,
                routing_num, account_num, check_num, account_type, micr);

            achinfo.SetImgFront(image_front);
            achinfo.SetImgBack(image_back);
            achinfo.SetDlNum(dl_num);
            achinfo.SetMagstripe(magstripe);

            ACHCredit achcredit = new ACHCredit();
            achcredit.SetOrderId(order_id);
            achcredit.SetAmount(amount);
            achcredit.SetAchInfo(achinfo);

            //************************OPTIONAL VARIABLES***************************

            //Cust_id Variable
            string cust_id = "customer1";
            achcredit.SetCustId(cust_id);

            HttpsPostRequest mpgReq = new HttpsPostRequest();
            mpgReq.SetProcCountryCode(processing_country_code);
            mpgReq.SetTestMode(true); //false or comment out this line for production transactions
            mpgReq.SetStoreId(store_id);
            mpgReq.SetApiToken(api_token);
            mpgReq.SetTransaction(achcredit);
            mpgReq.SetStatusCheck(status_check);
            mpgReq.Send();

            /*Status Check Example
               ACHHttpsPostRequest mpgReq = new ACHHttpsPostRequest(host, store_id, api_token, status, achcredit);  
             */

            /**********************   REQUEST  ************************/

            try
            {
                Receipt receipt = mpgReq.GetReceipt();

                Console.WriteLine("CardType = " + receipt.GetCardType());
                Console.WriteLine("TransAmount = " + receipt.GetTransAmount());
                Console.WriteLine("TxnNumber = " + receipt.GetTxnNumber());
                Console.WriteLine("ReceiptId = " + receipt.GetReceiptId());
                Console.WriteLine("TransType = " + receipt.GetTransType());
                Console.WriteLine("ReferenceNum = " + receipt.GetReferenceNum());
                Console.WriteLine("ResponseCode = " + receipt.GetResponseCode());
                Console.WriteLine("Message = " + receipt.GetMessage());
                Console.WriteLine("Complete = " + receipt.GetComplete());
                Console.WriteLine("TransDate = " + receipt.GetTransDate());
                Console.WriteLine("TransTime = " + receipt.GetTransTime());
                Console.WriteLine("Ticket = " + receipt.GetTicket());
                Console.WriteLine("TimedOut = " + receipt.GetTimedOut());
                //Console.WriteLine("StatusCode = " + receipt.GetStatusCode());
                //Console.WriteLine("StatusMessage = " + receipt.GetStatusMessage());
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
