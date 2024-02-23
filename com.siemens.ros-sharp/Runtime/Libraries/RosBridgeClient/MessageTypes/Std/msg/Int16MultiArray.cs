/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int16MultiArray : Message
    {
        public const string RosMessageName = "std_msgs/Int16MultiArray";

        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayout layout { get; set; }
        //  specification of data layout
        public short[] data { get; set; }
        //  array of data

        public Int16MultiArray()
        {
            this.layout = new MultiArrayLayout();
            this.data = new short[0];
        }

        public Int16MultiArray(MultiArrayLayout layout, short[] data)
        {
            this.layout = layout;
            this.data = data;
        }
    }
}
