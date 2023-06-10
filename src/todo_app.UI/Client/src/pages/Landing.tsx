import { HeroSection } from "../features/landing/HeroSection";
import { IconsSection } from "../features/landing/IconsSection";
import { LandingNavbar } from "../features/landing/LandingNavbar";
import { LastSection } from "../features/landing/LastSection";

export const Landing = () => {
  return (
    <div className="w-full flex flex-col items-center">
      <LandingNavbar />
      <HeroSection />
      <IconsSection />
      <LastSection />
    </div>
  );
};
