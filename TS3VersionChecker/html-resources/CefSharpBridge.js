            (async function ()
            {
                await CefSharp.BindObjectAsync("versionListObj");
				
                document.getElementById('show_verlist').addEventListener('click', async function ()
                {
			        versionListObj.openform();
                });
            })();
			
			(async function ()
            {
                await CefSharp.BindObjectAsync("requestBtnObj");
				
                document.getElementById('request_btn').addEventListener('click', async function ()
                {
			        requestBtnObj.requestsrv();
					
					var alpha = await requestBtnObj.getalpha();
					var beta = await requestBtnObj.getbeta();
					var server = await requestBtnObj.getserver();
					var stable = await requestBtnObj.getstable();
					var stable_linux_x86 = await requestBtnObj.getstable_linux_x86();
					var alpha_linux_x86 = await requestBtnObj.getalpha_linux_x86();
					var beta_linux_x86 = await requestBtnObj.getbeta_linux_x86();

					var fversion = await requestBtnObj.getfversion();
					var funix = await requestBtnObj.getfunix();
					var nowhttp = await requestBtnObj.getnowhttp();
					var nowlocal = await requestBtnObj.getnowlocal();
					var nowunix = await requestBtnObj.getnowunix();
					var udbhttp = await requestBtnObj.getudbhttp();
					var udblocal = await requestBtnObj.getudblocal();
					var udbunix = await requestBtnObj.getudbunix();
					var udbfhttp = await requestBtnObj.getudbfhttp();
					var udbflocal = await requestBtnObj.getudbflocal();
					var udbfunix = await requestBtnObj.getudbfunix();
					var bdbhttp = await requestBtnObj.getbdbhttp();
					var bdblocal = await requestBtnObj.getbdblocal();
					var bdbunix = await requestBtnObj.getbdbunix();
					var badgedata = await requestBtnObj.getbadgedata();
					var badgetimestamp = await requestBtnObj.getbadgetimestamp();
					var cbUNIX = document.getElementById('displayUNIX');
                	document.getElementById('ts3alpha').innerHTML = cbUNIX.checked ? alpha[1] : alpha[0];
					document.getElementById('ts3beta').innerHTML = cbUNIX.checked ? beta[1] : beta[0];
					document.getElementById('ts3server').innerHTML = cbUNIX.checked ? server[1] : server[0];
					document.getElementById('ts3stable').innerHTML = cbUNIX.checked ? stable[1] : stable[0];
					document.getElementById('ts3stable_linux_x86').innerHTML = cbUNIX.checked ? stable_linux_x86[1] : stable_linux_x86[0];
					document.getElementById('ts3alpha_linux_x86').innerHTML = cbUNIX.checked ? alpha_linux_x86[1] : alpha_linux_x86[0];
					document.getElementById('ts3beta_linux_x86').innerHTML = cbUNIX.checked ? beta_linux_x86[1] : beta_linux_x86[0];

					document.getElementById('ts5version').innerHTML = fversion;
					document.getElementById('ts5unix').innerHTML = cbUNIX.checked ? funix : parseUnixTime(funix);
					document.getElementById('nowhttp').innerHTML = nowhttp;
					document.getElementById('nowlocal').innerHTML = nowlocal;
					document.getElementById('nowunix').innerHTML = nowunix;
					document.getElementById('udbhttp').innerHTML = udbhttp;
					document.getElementById('udblocal').innerHTML = udblocal;
					document.getElementById('udbunix').innerHTML = udbunix;
					document.getElementById('udbfhttp').innerHTML = udbfhttp;
					document.getElementById('udbflocal').innerHTML = udbflocal;
					document.getElementById('udbfunix').innerHTML = udbfunix;
					document.getElementById('bdbhttp').innerHTML = bdbhttp;
					document.getElementById('bdblocal').innerHTML = bdblocal;
					document.getElementById('bdbunix').innerHTML = bdbunix;
					document.getElementById('listdate').innerHTML = cbUNIX.checked ? badgetimestamp : parseUnixTime(badgetimestamp);
					
					document.getElementById("lbBadges").innerHTML = "";
					for (var i = 1; i < badgedata.length; i++) {
					    var opt = document.createElement("option");
						opt.text = badgedata[i].Name;
                        opt.value = badgedata[i].Name;
                        document.getElementById("lbBadges").options.add(opt);
					}
					
					document.getElementById('lbBadges').addEventListener('click', async function ()
                    {
					    var lbBadges = document.getElementById("lbBadges");
			            var lblBadgeName = document.getElementById('badge_name');
						var lblBadgeDesc = document.getElementById('badge_desc');
						var lblBadgeUUID = document.getElementById('badge_uuid');
						var cbDetails = document.getElementById('displayDetails');
						var lblDate = document.getElementById('badgedate');
						var lblPNG = document.getElementById('pnglink');
						var lblSVG = document.getElementById('svglink');
						var pbSVG = document.getElementById('badge_svg');
						lblBadgeName.innerHTML = badgedata[lbBadges.selectedIndex + 1].Name;
						lblBadgeDesc.innerHTML = badgedata[lbBadges.selectedIndex + 1].Description;
						lblBadgeUUID.innerHTML = badgedata[lbBadges.selectedIndex + 1].UUID;
						
						cbDetails.enabled = true;
						
						if(cbDetails.checked){
							lblDate.innerHTML = badgedata[lbBadges.selectedIndex + 1].Timestamp;
						    lblPNG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_64.png";
							lblSVG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_details.svg";
							pbSVG.src = badgedata[lbBadges.selectedIndex + 1].URL + "_details.svg";
						} else {
							lblDate.innerHTML = parseUnixTime(badgedata[lbBadges.selectedIndex + 1].Timestamp);
						    lblPNG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_16.png";
							lblSVG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + ".svg";
							pbSVG.src = badgedata[lbBadges.selectedIndex + 1].URL + ".svg";
						}
                    });
					
					document.getElementById('displayDetails').addEventListener('click', async function ()
                    {
			            var lbBadges = document.getElementById("lbBadges");
			            var lblBadgeName = document.getElementById('badge_name');
						var lblBadgeDesc = document.getElementById('badge_desc');
						var lblBadgeUUID = document.getElementById('badge_uuid');
						var cbDetails = document.getElementById('displayDetails');
						var lblDate = document.getElementById('badgedate');
						var lblPNG = document.getElementById('pnglink');
						var lblSVG = document.getElementById('svglink');
						var pbSVG = document.getElementById('badge_svg');
						lblBadgeName.innerHTML = badgedata[lbBadges.selectedIndex + 1].Name;
						lblBadgeDesc.innerHTML = badgedata[lbBadges.selectedIndex + 1].Description;
						lblBadgeUUID.innerHTML = badgedata[lbBadges.selectedIndex + 1].UUID;
						
						cbDetails.enabled = true;
						
						if(cbDetails.checked){
							lblDate.innerHTML = badgedata[lbBadges.selectedIndex + 1].Timestamp;
						    lblPNG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_64.png";
							lblSVG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_details.svg";
							pbSVG.src = badgedata[lbBadges.selectedIndex + 1].URL + "_details.svg";
						} else {
							lblDate.innerHTML = parseUnixTime(badgedata[lbBadges.selectedIndex + 1].Timestamp);
						    lblPNG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + "_16.png";
							lblSVG.innerHTML = badgedata[lbBadges.selectedIndex + 1].URL + ".svg";
							pbSVG.src = badgedata[lbBadges.selectedIndex + 1].URL + ".svg";
						}
                    });

					document.getElementById('displayUNIX').addEventListener('click', async function ()
					{
						var lalpha = document.getElementById('ts3alpha');
						var lbeta = document.getElementById('ts3beta');
						var lserver = document.getElementById('ts3server');
						var lstable = document.getElementById('ts3stable');
						var lstable_linux_x86 = document.getElementById('ts3stable_linux_x86');
						var lalpha_linux_x86 = document.getElementById('ts3alpha_linux_x86');
						var lbeta_linux_x86 = document.getElementById('ts3beta_linux_x86');

						var lfunix = document.getElementById('ts5unix');
						var ldate = document.getElementById('listdate');
						var cbUNIX = document.getElementById('displayUNIX');
						
						cbUNIX.enabled = true;
						
						if(cbUNIX.checked){
							lalpha.innerHTML = alpha[1];
							lbeta.innerHTML = beta[1];
							lserver.innerHTML = server[1];
							lstable.innerHTML = stable[1];
							lstable_linux_x86.innerHTML = stable_linux_x86[1];
							lalpha_linux_x86.innerHTML = alpha_linux_x86[1];
							lbeta_linux_x86.innerHTML = beta_linux_x86[1];

							lfunix.innerHTML = funix;
							ldate.innerHTML = badgetimestamp;
						} else {
							lalpha.innerHTML = alpha[0];
							lbeta.innerHTML = beta[0];
							lserver.innerHTML = server[0];
							lstable.innerHTML = stable[0];
							lstable_linux_x86.innerHTML = stable_linux_x86[0];
							lalpha_linux_x86.innerHTML = alpha_linux_x86[0];
							lbeta_linux_x86.innerHTML = beta_linux_x86[0];

							lfunix.innerHTML = parseUnixTime(funix);
							ldate.innerHTML = parseUnixTime(badgetimestamp);
						}
                    });

					function parseUnixTime(unix_timestamp){
						var date = new Date(unix_timestamp * 1000);
						var curr_date = "0" + date.getDate();
						var curr_month = "0" + (date.getMonth() + 1); //Months are zero based
						var curr_year = date.getFullYear();
						var hours = "0" + date.getHours();
						var minutes = "0" + date.getMinutes();
						var seconds = "0" + date.getSeconds();
						var formattedTime = curr_date.substr(-2) + '.' + curr_month.substr(-2)  + '.' + curr_year + ' ' + hours.substr(-2) + ':' + minutes.substr(-2) + ':' + seconds.substr(-2);
						return formattedTime;
					}
                });
            })();
			
			(async function ()
            {
                await CefSharp.BindObjectAsync("feedbackBtnObj");
				
                document.getElementById('feedback_btn').addEventListener('click', async function ()
                {
			        feedbackBtnObj.openform();
                });
            })();
			
			(async function ()
            {
                await CefSharp.BindObjectAsync("nickResolveObj");
				
                document.getElementById('nick_btn').addEventListener('click', async function ()
                {
			        nickResolveObj.resolvenick(document.getElementById('tb_nickname').value).then(ret_val => {
					    document.getElementById('tb_ipaddress').value = ret_val;
                    });
                });
            })();

			(async function ()
            {
                await CefSharp.BindObjectAsync("matrixResolveObj");
				
                document.getElementById('matrix_btn').addEventListener('click', async function ()
                {
			        matrixResolveObj.resolvematrix(document.getElementById('tb_usertag').value).then(ret_val => {
					    document.getElementById('tb_matrixid').value = ret_val;
                    });
                });
            })();
			
			(async function ()
            {
                await CefSharp.BindObjectAsync("contextMenuObj");
				
				var menu_options = document.getElementsByClassName("menu-option");
				for (var i = 0; i < menu_options.length; i++){
					menu_options[i].addEventListener('click', function(e){
						contextMenuObj.handlecontextmenu(this.id);
					});
				}   
            })();