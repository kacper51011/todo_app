import { IconBase } from "react-icons";
import { RiTodoFill } from "react-icons/ri";

type props = {
  showText: boolean;
  color: "main" | "black";
};

export const Logo = ({ showText, color }: props) => {
  return (
    <div aria-label="logo" className="flex h-full items-center">
      <IconBase fontSize="30px" color="#FF4F5A" className="mr-2">
        <RiTodoFill />
      </IconBase>

      {showText && color === "main" && <h1 className="text-main font-extrabold">Todo&nbsp;App</h1>}
      {showText && color === "black" && <h1 className="text-black font-extrabold">Todo&nbsp;App</h1>}
    </div>
  );
};
