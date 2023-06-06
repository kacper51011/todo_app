import { IconBase } from "react-icons";
import { RiTodoFill } from "react-icons/ri";

type props = {
  showText: boolean;
  color: "main" | "white";
};

export const Logo = ({ showText, color }: props) => {
  return (
    <div aria-label="logo" className="flex h-full items-center">
      <IconBase fontSize="30px" color="red">
        <RiTodoFill />
      </IconBase>

      {showText && color === "main" && <h1 className="text-main">Todo&nbsp;App</h1>}
      {showText && color === "white" && <h1 className="text-white">Todo&nbsp;App</h1>}
    </div>
  );
};
