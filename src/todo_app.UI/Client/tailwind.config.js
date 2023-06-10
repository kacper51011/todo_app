/** @type {import('tailwindcss').Config} */
export default {
  content: ["./src/**/**/**.{html,js,jsx,ts,tsx}", ,],
  theme: {
    extend: {
      colors: {
        main: "#FF4F5A",
        error: "#e30b19",
        lightText: "#F8F7FA",
        lightDarkText: "#DDE0FF1F",
        darkBackground: "#262627",
      },
    },
  },
  plugins: [],
};
