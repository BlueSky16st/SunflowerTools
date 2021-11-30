document.addEventListener('DOMContentLoaded', () => {
  var intervalCountdown = 0;
  var intervalId = setInterval(() => {
    var tbAd = document.getElementsByClassName('toolbar-advert');
    if (tbAd !== undefined && tbAd.length > 0) {
      tbAd[0].style.display = 'none';
      console.log('已经帮你关掉恶心的广告了!');
      clearInterval(intervalId);
      return;
    }
    // console.log('每隔一段时间查找一次...');
    intervalCountdown++;

    if (intervalCountdown >= 20) clearInterval(intervalId);
  }, 500);
});
