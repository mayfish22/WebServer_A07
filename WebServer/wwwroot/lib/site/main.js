async function setLanguage(lang) {
    location.href = `/Account/SetLanguage?culture=${lang}&returnUrl=${encodeURIComponent(location.href)}`;
}