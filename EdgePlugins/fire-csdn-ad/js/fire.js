document.addEventListener('DOMContentLoaded', () => {
  var tbAd = document.getElementsByClassName('toolbar-advert');
  if (tbAd !== undefined && tbAd.length > 0) {
    tbAd[0].style.display = 'none';
    console.log('已经帮你关掉恶心的广告了!');
  }
});
