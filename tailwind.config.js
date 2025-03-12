/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./LOrdCardShop/*.aspx",
    "./LOrdCardShop/Views/**/*.aspx",
    "./LOrdCardShop/Views/**/*.ascx",
    "./LOrdCardShop/Scripts/**/*.js",
    "./LOrdCardShop/Style/**/*.css",
  ],
  theme: {
    extend: {
      colors: {
        primary: "#3b82f6",
        secondary: "#10b981",
        accent: "#8b5cf6",
        background: "#f9fafb",
        card: "#ffffff",
      },
    },
  },
  plugins: [],
};
